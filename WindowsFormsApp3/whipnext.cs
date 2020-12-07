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
    public partial class whipnext : MetroSetForm
    {
        public whipnext()
        {
            InitializeComponent();
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            selector selector = new selector();
            this.Hide();
            selector.Show();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (check10.Checked == true)
            {
                app10 app10 = new app10();
                this.Hide();
                app10.Show();
            }
            if (check20.Checked == true)
            {
                app20 app20 = new app20();
                this.Hide();
                app20.Show();
            }
            if (check30.Checked == true)
            {
                app30 app30 = new app30();
                this.Hide();
                app30.Show();
            }
            if (check40.Checked == true)
            {
                app40 app40 = new app40();
                this.Hide();
                app40.Show();
            }
            if (check50.Checked == true)
            {
                app50 app50 = new app50();
                this.Hide();
                app50.Show();
            }
            if (check60.Checked == true)
            {
                app60 app60 = new app60();
                this.Hide();
                app60.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
