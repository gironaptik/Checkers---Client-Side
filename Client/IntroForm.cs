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
    public partial class IntroForm : Form
    {
        private BindingSource TblPlayersBindingSource = new BindingSource();
        private static HttpClient client = new HttpClient();
        private ClientGameDataContext db = new ClientGameDataContext();
        private const string registerPath = "https://localhost:44371/Players/Create";
        private Player loggedPlayer;

        public IntroForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44371/");

        }

        private async void login_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;
            string path = "api/TblPlayers/login?name=" + userName + "&password=" + password;

            HttpResponseMessage httpResponse = await client.GetAsync(path);
            if(httpResponse.IsSuccessStatusCode)
            {
                loggedPlayer = await httpResponse.Content.ReadAsAsync<Player>();
                if (!db.TblPlayers.Any(c => c.Id == loggedPlayer.Id))
                {
                    db.TblPlayers.InsertOnSubmit(loggedPlayer.convertToEntity());
                    db.SubmitChanges();
                }

                MenuForm menu = new MenuForm(loggedPlayer);
                this.Visible = false;
                menu.ShowDialog();
                this.Close();

            }
            else
            {
                string message = "Username or Password incorrect";
                string title = "Login Error";
                MessageBox.Show(message, title);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameClick(object sender, MouseEventArgs e)
        {
            userNameBox.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(registerPath);
        }
    }
}
