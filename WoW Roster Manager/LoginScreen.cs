using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW_Roster_Manager
{
    public partial class LoginPage : Form
    {

        private DBConnector dbConnector;
        public LoginPage()
        {
            InitializeComponent();
            dbConnector = new DBConnector();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = textBox1.Text;

            dbConnector.Connect();
            bool auth = dbConnector.Authenticate(username, password);

            if (auth)
            {
                MessageBox.Show("Login successful!");
                RosterViewer rosterViewer = new RosterViewer();
                rosterViewer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
            dbConnector.Disconnect();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = textBox1.Text;

            // Password validation... > 8 characters
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            dbConnector.Connect();
            bool success = dbConnector.Register(username, password);

            if (success)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
            dbConnector.Disconnect();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
