using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class RecordedGamesForm : Form
    {
        private Player currentPlayer;
        private ClientGameDataContext db = new ClientGameDataContext();
        private List<TblGame> playerGames = new List<TblGame>();


        public RecordedGamesForm(Player loggedPlayer)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            currentPlayer = loggedPlayer;
        }

        private void HistoricalGamesForm_Load(object sender, EventArgs e)
        {
            playerGames = db.TblGames.Where(c => c.PlayerId == currentPlayer.Id).OrderByDescending(c=> c.Id).ToList();
            foreach(TblGame game in playerGames)
            {
                gamesListBox.Items.Add(game.Date);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string requestedDate = gamesListBox.SelectedItem.ToString();
            TblGame requestedGame = db.TblGames.Where(c => c.PlayerId == currentPlayer.Id && c.Date == requestedDate).First();

            GameForm game = new GameForm(currentPlayer, requestedGame, true);
            Visible = false;
            game.ShowDialog();
            Close();
        }

        private void gamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
