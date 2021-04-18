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
    public partial class EventCreate : Form
    {
        public EventCreate()
        {
            InitializeComponent();
        }

        private void EventCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            eventPictureBox.ImageLocation = openFileDialog1.FileName;
        }
    }
}
