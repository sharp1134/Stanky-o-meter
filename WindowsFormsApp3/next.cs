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
    public partial class next : MetroSetForm
    {
        public next()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void next_Load(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            selector selector = new selector();
            this.Hide();
            selector.Show();
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            chart chart = new chart();
            this.Hide();
            chart.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
