using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            RunClock();
        }

        public void RunClock()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                clock_lbl.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
                clock_lbl.Refresh();
            };

            timer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShiftSwitchButton_Click(object sender, EventArgs e)
        {

        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
