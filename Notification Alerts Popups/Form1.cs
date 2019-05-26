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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            alerts.Show("Hello World", alerts.AlertType.success);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            alerts.Show("Hello World", alerts.AlertType.error);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            alerts.Show("Hello World", alerts.AlertType.info);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            alerts.Show("Hello World", alerts.AlertType.warnig);
        }
    }
}
