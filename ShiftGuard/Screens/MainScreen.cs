using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftGuard
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            getServerDateTime();
        
        }

        public void getServerDateTime()
        {
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (s, e) =>
            {
                ServerTimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
                ServerDateLbl.Refresh();
            };

            timer.Start();
      
            ServerDateLbl.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void ShiftSwitchButton_Click(object sender, EventArgs e)
        {

        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void timerPanel_Click(object sender, EventArgs e)
        {

        }

        private void TimeSheetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
