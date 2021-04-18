using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDairy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            EventCreate eventCreate = new EventCreate();
            eventCreate.Show();
            this.Hide();
        }
    }
}
