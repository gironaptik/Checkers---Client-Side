using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GameForm : Form
    {
        private const int serverId = 1;
        private const int playerId = 2;
        private const int boardRows = 8;
        private const int boardColumns = 4;
        private const int soldierCellSize = 50;
        private int[][] board = new int[boardRows][];
        private Button[,] buttons = new Button[boardRows, boardColumns];
        private List<Button> simpleSteps = new List<Button>();
        private int currentPlayer;
        private int turnCounter;
        private int playerScore;
        private int eatenI;
        private int eatenJ;
        private Button prevButton;
        private Button pressedButton;
        private bool isMoving;
        private bool isContinue = false;
        private Player loggedPlayer;
        private TblGame tblGameSave = new TblGame();
        private Image playerSoldier;
        private Image serverSoldier;
        private bool historicalGameRequest = false;
        private static HttpClient client = new HttpClient();
        private Color blank2 = Color.FromArgb(39, 55, 74);
        private TblTurnsHistory turnsRecord = new TblTurnsHistory();
        private const string decisionPath = "api/TblGames/nextstep";
        private const string saveGamePath = "api/TblGames";
        private ClientGameDataContext db = new ClientGameDataContext();

        public GameForm(Player player, TblGame tblGame, bool historicalGame = false)
        {
            InitializeComponent();
            Text = "Damka";
            playerSoldier = new Bitmap(new Bitmap(@"C:\Client\Client\assets\s.png"), new Size(soldierCellSize - 10, soldierCellSize - 10));
            serverSoldier = new Bitmap(new Bitmap(@"C:\Client\Client\assets\p.png"), new Size(soldierCellSize - 10, soldierCellSize - 10));

            historicalGameRequest = historicalGame;
            loggedPlayer = player;
            tblGameSave = tblGame;
            turnsRecord.GameId = tblGame.Id;

        }

        //Initial Game attributes
        public void InitGame()
        {
            currentPlayer = 1;
            isMoving = false;
            prevButton = null;
            turnCounter = 0;
            board[0] = new int[boardColumns] { 0, 1, 0, 1 };
            board[1] = new int[boardColumns] { 1, 0, 1, 0 };
            board[2] = new int[boardColumns] { 0, 0, 0, 0 };
            board[3] = new int[boardColumns] { 0, 0, 0, 0 };
            board[4] = new int[boardColumns] { 0, 0, 0, 0 };
            board[5] = new int[boardColumns] { 0, 0, 0, 0 };
            board[6] = new int[boardColumns] { 0, 2, 0, 2 };
            board[7] = new int[boardColumns] { 2, 0, 2, 0 };
            CreateBoard();

            if (historicalGameRequest)
                startHistoricalGame();
            else
                serverTurn();
        }

        //Creating MemoryCard board
        public void CreateBoard()
        {
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * soldierCellSize, i * soldierCellSize);
                    button.Size = new Size(soldierCellSize, soldierCellSize);
                    button.Click += new EventHandler(soldierPressed);
                    if (board[i][j] == 1)
                        button.Image = serverSoldier;
                    else if (board[i][j] == 2)
                        button.Image = playerSoldier;

                    button.BackColor = GetPrevButtonColor(button);
                    button.ForeColor = Color.Red;
                    buttons[i, j] = button;
                    boardBox.Controls.Add(button);
                }
            }
        }
        public async void startHistoricalGame()
        {
            List<TblTurnsHistory> turnsList = new List<TblTurnsHistory>();
            turnsList = db.TblTurnsHistories.Where(c => c.GameId == tblGameSave.Id).OrderBy(c => c.Id).ToList();
            foreach (TblTurnsHistory turn in turnsList)
            {
                await Task.Delay(500);
                //System.Threading.Thread.Sleep(500);

                TurnManagment turnManagment = new TurnManagment()
                {
                    IFromAnswer = turn.FromIPoint ?? default,
                    JFromAnswer = turn.FromJPoint ?? default,
                    IToAnswer = turn.ToIPoint ?? default,
                    JToAnswer = turn.ToJPoint ?? default,
                    EndOfRoad = false
                };
                pressedButton = buttons[turnManagment.IFromAnswer, turnManagment.JFromAnswer];
                playTurn();
                System.Threading.Thread.Sleep(500);

                pressedButton = buttons[turnManagment.IToAnswer, turnManagment.JToAnswer];
                playTurn();
                System.Threading.Thread.Sleep(500);
            }
        }
        public void SwitchPlayer()
        {
            currentPlayer = currentPlayer == serverId ? playerId : serverId;
            CheckGameStatus();
        }

        public void soldierPressed(object sender, EventArgs e)
        {
            if (prevButton != null)
                prevButton.BackColor = GetPrevButtonColor(prevButton);
            pressedButton = sender as Button;
            playTurn();
        }

        public void playTurn()
        {

            if (board[pressedButton.Location.Y / soldierCellSize][pressedButton.Location.X / soldierCellSize] != 0 && board[pressedButton.Location.Y / soldierCellSize][pressedButton.Location.X / soldierCellSize] == currentPlayer)
            {
                CloseSteps();
                pressedButton.BackColor = Color.Red;
                DisableButtons();
                pressedButton.Enabled = true;
                ShowSteps(pressedButton.Location.Y / soldierCellSize, pressedButton.Location.X / soldierCellSize);

                if (isMoving)
                {
                    CloseSteps();
                    pressedButton.BackColor = GetPrevButtonColor(pressedButton);
                    EnableButtons();

                    isMoving = false;
                }
                else
                    isMoving = true;
            }
            else
            {
                if (isMoving)
                {
                    isContinue = false;
                    if (Math.Abs(pressedButton.Location.X / soldierCellSize - prevButton.Location.X / soldierCellSize) > 1)
                    {
                        isContinue = true;
                        DeleteEaten(pressedButton, prevButton);
                    }
                    if (!historicalGameRequest)
                        saveStep();
                    int temp = board[pressedButton.Location.Y / soldierCellSize][pressedButton.Location.X / soldierCellSize];
                    board[pressedButton.Location.Y / soldierCellSize][pressedButton.Location.X / soldierCellSize] = board[prevButton.Location.Y / soldierCellSize][prevButton.Location.X / soldierCellSize];
                    board[prevButton.Location.Y / soldierCellSize][prevButton.Location.X / soldierCellSize] = temp;

                    pressedButton.Image = prevButton.Image;
                    prevButton.Image = null;
                    isMoving = false;
                    CloseSteps();
                    DisableButtons();

                    CloseSteps();
                    SwitchPlayer();
                    EnableButtons();
                    isContinue = false;
                }
            }
            prevButton = pressedButton;
        }

        public async void serverTurn()
        {
            if (currentPlayer == serverId)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(decisionPath, board);
                if (response.IsSuccessStatusCode)
                {
                    TurnManagment turnManagment = await response.Content.ReadAsAsync<TurnManagment>();
                    if (turnManagment.EndOfRoad)
                        WinAlert();
                    pressedButton = buttons[turnManagment.IFromAnswer, turnManagment.JFromAnswer];
                    playTurn();
                    await Task.Delay(500);
                    pressedButton = buttons[turnManagment.IToAnswer, turnManagment.JToAnswer];
                    playTurn();
                }
            }
        }

        public void ShowSteps(int iCurrFigure, int jCurrFigure, bool isOnestep = true)
        {
            simpleSteps.Clear();
            ShowDiagonal(iCurrFigure, jCurrFigure, isOnestep);
        }

        public void DeleteEaten(Button endButton, Button startButton)
        {
            int startIndexX = endButton.Location.Y / soldierCellSize - startButton.Location.Y / soldierCellSize;
            int startIndexY = endButton.Location.X / soldierCellSize - startButton.Location.X / soldierCellSize;
            startIndexX = startIndexX < 0 ? -1 : 1;
            startIndexY = startIndexY < 0 ? -1 : 1;
            int i = startButton.Location.Y / soldierCellSize + startIndexX;
            int j = startButton.Location.X / soldierCellSize + startIndexY;
            board[i][j] = 0;
            eatenI = i;
            eatenJ = j;
            eatenTimer.Start();
            buttons[i, j].Text = "";
            if (currentPlayer == playerId)
            {
                playerScore += 10;
                scoreLabel.Text = playerScore.ToString();
            }
        }

        public Color GetPrevButtonColor(Button prevButton)
        {
            if (prevButton.Location.Y / soldierCellSize % 2 != 0)
            {
                if (prevButton.Location.X / soldierCellSize % 2 == 0)
                {
                    return blank2;
                }
            }
            if (prevButton.Location.Y / soldierCellSize % 2 == 0)
            {
                if (prevButton.Location.X / soldierCellSize % 2 != 0)
                {
                    return blank2;
                }
            }
            return Color.White;
        }

        public void ShowDiagonal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == serverId && isOneStep && !isContinue) break;
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == serverId && isOneStep && !isContinue) break;
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < boardRows; i++)
            {
                if (currentPlayer == playerId && isOneStep && !isContinue) break;
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == playerId && isOneStep && !isContinue) break;
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }
        }

        public bool DeterminePath(int ti, int tj)
        {

            if (board[ti][tj] == 0 && !isContinue)
            {
                buttons[ti, tj].BackColor = Color.Yellow;
                buttons[ti, tj].Enabled = true;
                simpleSteps.Add(buttons[ti, tj]);
            }
            else
            {

                if (board[ti][tj] != currentPlayer)
                {
                    EatPath(ti, tj);
                }
                return false;
            }
            return true;
        }

        public void EatPath(int i, int j, bool isOneStep = true)
        {
            int dirX = i - pressedButton.Location.Y / soldierCellSize;
            int dirY = j - pressedButton.Location.X / soldierCellSize;
            dirX = dirX < 0 ? -1 : 1;
            dirY = dirY < 0 ? -1 : 1;
            int il = i;
            int jl = j;
            bool isEmpty = true;
            while (IsInsideBorders(il, jl))
            {
                if (board[il][jl] != 0 && board[il][jl] != currentPlayer)
                {
                    isEmpty = false;
                    break;
                }
                il += dirX;
                jl += dirY;

                if (isOneStep)
                    break;
            }
            if (isEmpty)
                return;
            List<Button> toClose = new List<Button>();
            bool closeSimple = false;
            int ik = il + dirX;
            int jk = jl + dirY;
            while (IsInsideBorders(ik, jk))
            {
                if (board[ik][jk] == 0)
                {
                    if (IsButtonHasEatStep(ik, jk, isOneStep, new int[2] { dirX, dirY }))
                    {
                        closeSimple = true;
                    }
                    else
                    {
                        toClose.Add(buttons[ik, jk]);
                    }
                    buttons[ik, jk].BackColor = Color.Yellow;
                    buttons[ik, jk].Enabled = true;
                }
                else break;
                if (isOneStep)
                    break;
                jk += dirY;
                ik += dirX;
            }
        }

        public bool IsButtonHasEatStep(int IcurrFigure, int JcurrFigure, bool isOneStep, int[] dir)
        {
            bool eatStep = false;
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == serverId && isOneStep && !isContinue) break;
                if (dir[0] == 1 && dir[1] == -1 && !isOneStep) break;
                if (IsInsideBorders(i, j))
                {
                    if (board[i][j] != 0 && board[i][j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i - 1, j + 1))
                            eatStep = false;
                        else if (board[i - 1][j + 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == serverId && isOneStep && !isContinue) break;
                if (dir[0] == 1 && dir[1] == 1 && !isOneStep) break;
                if (IsInsideBorders(i, j))
                {
                    if (board[i][j] != 0 && board[i][j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i - 1, j - 1))
                            eatStep = false;
                        else if (board[i - 1][j - 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == playerId && isOneStep && !isContinue) break;
                if (dir[0] == -1 && dir[1] == 1 && !isOneStep) break;
                if (IsInsideBorders(i, j))
                {
                    if (board[i][j] != 0 && board[i][j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i + 1, j - 1))
                            eatStep = false;
                        else if (board[i + 1][j - 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == playerId && isOneStep && !isContinue) break;
                if (dir[0] == -1 && dir[1] == -1 && !isOneStep) break;
                if (IsInsideBorders(i, j))
                {
                    if (board[i][j] != 0 && board[i][j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i + 1, j + 1))
                            eatStep = false;
                        else if (board[i + 1][j + 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }
            return eatStep;
        }

        public bool IsInsideBorders(int ti, int tj)
        {
            if (ti >= boardRows || tj >= boardColumns || ti < 0 || tj < 0)
            {
                return false;
            }
            return true;
        }

        public void CloseSteps()
        {
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    buttons[i, j].BackColor = GetPrevButtonColor(buttons[i, j]);
                }
            }
        }

        public void CheckGameStatus()
        {
            bool player1 = false;
            bool player2 = false;
            if (!NextStepExist())
                WinAlert();
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    if (board[i][j] == serverId)
                        player1 = true;
                    if (board[i][j] == playerId)
                        player2 = true;

                    if ((i == 0) && (board[i][j] == playerId))
                    {
                        WinAlert();
                    }
                    if ((i == boardRows - 1) && (board[i][j] == serverId))
                    {
                        WinAlert();
                    }

                }
            }
            if (!historicalGameRequest)
                serverTurn();
            if (!player1 || !player2)
            {
                WinAlert();
            }

        }

        public bool NextStepExist()
        {
            if (currentPlayer == serverId)
                return true;
            if (currentPlayer == playerId)
            {
                for (int i = boardRows - 1; i >= 0; i--)
                {
                    for (int j = 0; j < boardColumns; j++)
                    {
                        if (board[i][j] == 2 && IsInsideBorders(i - 1, j + 1))
                        {
                            if (board[i - 1][j + 1] == 1 && IsInsideBorders(i - 2, j + 2))
                            {
                                if (board[i - 2][j + 2] == 0)
                                    return true;
                            }
                            if (board[i - 1][j + 1] == 0)
                                return true;
                        }
                        if (board[i][j] == 2 && IsInsideBorders(i - 1, j - 1))
                        {
                            if (board[i - 1][j - 1] == 1 && IsInsideBorders(i - 2, j - 2))
                            {
                                if (board[i - 2][j - 2] == 0)
                                    return true;
                            }
                            if (board[i - 1][j - 1] == 0)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public void WinAlert()
        {
            int player;
            string winnerName;
            player = currentPlayer == serverId ? playerId : serverId;
            winnerName = player == 1 ? "Server" : loggedPlayer.Name;
            SaveGameInServer();
            var selectedOption = MessageBox.Show(winnerName.Trim() + " won, Game Over");
            if (selectedOption == DialogResult.OK)
            {
                InitGame();
                Close();
            }
        }

        private async void SaveGameInServer()
        {
            Game saveGameInServer = new Game()
            {
                PlayerId = loggedPlayer.Id,
                PlayerName = loggedPlayer.Name,
                Score = Int32.Parse(scoreLabel.Text),
                Date = DateTime.Now
            };
            await client.PostAsJsonAsync(saveGamePath, saveGameInServer);
        }
        public void DisableButtons()
        {
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
        }

        public void EnableButtons()
        {
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    buttons[i, j].Enabled = true;
                }
            }
        }

        private void saveStep()
        {
            turnsRecord.TurnNumber = turnCounter;
            turnCounter++;
            turnsRecord.FromIPoint = prevButton.Location.Y / soldierCellSize;
            turnsRecord.FromJPoint = prevButton.Location.X / soldierCellSize;
            turnsRecord.ToIPoint = pressedButton.Location.Y / soldierCellSize;
            turnsRecord.ToJPoint = pressedButton.Location.X / soldierCellSize;
            db.TblTurnsHistories.InsertOnSubmit(turnsRecord);
            db.SubmitChanges();
            turnsRecord = new TblTurnsHistory() { GameId = tblGameSave.Id };
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            eatenTimer.Interval = 100;
            if (client.BaseAddress == null)
                client.BaseAddress = new Uri("https://localhost:44371/");
            InitGame();
        }

        private void eatenTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (currentPlayer == serverId)
                    buttons[eatenI, eatenJ].Image = new Bitmap(new Bitmap(@"C:\Client\Client\assets\p.png"), new Size(buttons[eatenI, eatenJ].Image.Size.Width / 2, buttons[eatenI, eatenJ].Image.Size.Height / 2));
                else
                    buttons[eatenI, eatenJ].Image = new Bitmap(new Bitmap(@"C:\Client\Client\assets\s.png"), new Size(buttons[eatenI, eatenJ].Image.Size.Width / 2, buttons[eatenI, eatenJ].Image.Size.Height / 2));
                if (buttons[eatenI, eatenJ].Image.Size.Width <= 0 || buttons[eatenI, eatenJ].Image.Size.Height <= 0)
                {
                    eatenTimer.Stop();
                    buttons[eatenI, eatenJ].Image = null;
                }
            }
            catch (ArgumentException)
            {
                eatenTimer.Stop();
                buttons[eatenI, eatenJ].Image = null;
            }
        }

        private void boardBox_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            InitGame();
            this.Visible = false;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private async void refresh_button_Click(object sender, EventArgs e)
        {
            await LoadingF();
        }

        static async Task<bool> LoadingF()
        {
            await Task.Delay(3000);
            return true;
        }
    }
}