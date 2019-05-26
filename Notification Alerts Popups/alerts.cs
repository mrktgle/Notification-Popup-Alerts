using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification_Alerts_Popups
{
    public partial class alerts : Form
    {
        int interval = 0;

        public alerts(string _message, AlertType type)
        {
            InitializeComponent();
            message.Text = _message;
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    //icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    //icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warnig:
                    this.BackColor = Color.Crimson;
                    //icon.Image = imageList1.Images[1];
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    //icon.Image = imageList1.Images[2];
                    break;

            }
        }

        public enum AlertType
        {
            success, info, warnig, error
        }

        public static void Show(string message, AlertType type)
        {
            new alerts(message, type).Show();
        }

        private void alerts_Load(object sender, EventArgs e)
        {
            //set position to top left...
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            showw.Start();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void showw_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval; // drop the alert
                interval += 2; // double the speed
            }
            else
            {
                showw.Stop();
            }
        }

        private void closealert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2; //reduce opacity to zero
            }
            else
            {
                this.Close(); //then close
            }
        }

    }
}
