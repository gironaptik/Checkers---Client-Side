using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Client
{
    public partial class ProfileForm : Form
    {
        private Player loggedPlayer;
        private static HttpClient client = new HttpClient();
        private string updateProfilePath = "api/TblPlayers/";

        public ProfileForm(Player player)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            loggedPlayer = player;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44371/");
            nameTextBox.Text = loggedPlayer.Name.Trim();
            emailTextBox.Text = loggedPlayer.Email.Trim();
            passwordTextBox.Text = loggedPlayer.Password.Trim();
            numOfGamesTextBox.Text = loggedPlayer.NumOfGames.ToString();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            updateProfilePath = updateProfilePath + loggedPlayer.Id;
            loggedPlayer.Name = nameTextBox.Text;
            loggedPlayer.Email = emailTextBox.Text;
            loggedPlayer.Password = passwordTextBox.Text;
            HttpResponseMessage response = await client.PutAsJsonAsync(updateProfilePath, loggedPlayer);
            if (response.IsSuccessStatusCode)
            {
                var selectedOption = MessageBox.Show("User Updated, please login again");
                if (selectedOption == DialogResult.OK)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Close();
        }
    }
}
