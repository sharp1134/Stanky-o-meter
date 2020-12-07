using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace WindowsFormsApp3
{
    public partial class selector : MetroSetForm
    {
        public selector()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            millynext millynext = new millynext();
            this.Hide();
            millynext.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            whipnext whipnext = new whipnext();
            this.Hide();
            whipnext.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            stankynext stankynext = new stankynext();
            this.Hide();
            stankynext.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
