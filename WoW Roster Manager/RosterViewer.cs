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
    public partial class RosterViewer : Form
    {
        public RosterViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // If roster viewer is closed, close the application
        private void RosterViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void renameRosterButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void createRosterButton_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
