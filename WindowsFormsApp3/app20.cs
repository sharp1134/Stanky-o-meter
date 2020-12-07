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
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp3
{
    public partial class app20 : MetroSetForm
    {
        public app20()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void app20_Load(object sender, EventArgs e)
        {
            num3.Visible = false;
            num2.Visible = false;
            num1.Visible = false;
            num0.Visible = false;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Invoke((MethodInvoker)(delegate ()
            {
                var imagevid = (Bitmap)eventArgs.Frame.Clone();
                pic.Image = imagevid;
            }));
        }

        private async void metroSetButton1_Click(object sender, EventArgs e)
        {
            num3.Visible = true;
            await Task.Delay(1000);
            num3.Visible = false;
            num2.Visible = true;
            await Task.Delay(1000);
            num2.Visible = false;
            num1.Visible = true;
            await Task.Delay(1000);
            num1.Visible = false;
            num0.Visible = true;
            await Task.Delay(200);
            num0.Visible = false;
            await Task.Delay(20000);
            Random random = new Random();
            var rnd = new Random();
            int result = rnd.Next(1, 4);
            if (result == 1)
            {
                onescore onescore = new onescore();
                this.Hide();
                onescore.Show();
            }
            if (result == 2)
            {
                twoscore twoscore = new twoscore();
                this.Hide();
                twoscore.Show();
            }
            if (result == 3)
            {
                threescore threescore = new threescore();
                this.Hide();
                threescore.Show();
            }
            if (result == 4)
            {
                fourscore fourscore = new fourscore();
                this.Hide();
                fourscore.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
