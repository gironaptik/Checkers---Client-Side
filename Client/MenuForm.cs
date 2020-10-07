using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MenuForm : Form
    {
        private string updateGamePath = "api/TblPlayers/updateGames?id=";
        private Player loggedPlayer;
        private ClientGameDataContext db = new ClientGameDataContext();
        private static HttpClient client = new HttpClient();


        public MenuForm(Player player)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            loggedPlayer = player;
            updateGamePath = updateGamePath + loggedPlayer.Id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://localhost:44371/");
            }
            titleLabel.Text = "Hey " + loggedPlayer.Name.Trim();
        }

        private async void gameButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(updateGamePath, loggedPlayer.Id);
            if (response.IsSuccessStatusCode)
            {
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");
                db.TblGames.InsertOnSubmit(new TblGame { PlayerId = loggedPlayer.Id, Date = date });
                db.SubmitChanges();
                TblGame tblGame = db.TblGames.OrderByDescending(g => g.Id).FirstOrDefault(p => p.PlayerId == loggedPlayer.Id);
                db.TblGamesByPlayers.InsertOnSubmit(new TblGamesByPlayer { IdGame = tblGame.Id, IdPlayer = loggedPlayer.Id });
                db.SubmitChanges();
                GameForm game = new GameForm(loggedPlayer, tblGame, false);
                //this.Visible = false;
                game.ShowDialog();
                //this.Close();

            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(loggedPlayer);
            profile.ShowDialog();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            RecordedGamesForm list = new RecordedGamesForm(loggedPlayer);
            list.ShowDialog();
        }
    }
}
