using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GetBalance.UI
{
    public partial class FormHatirlatici : Form
    {
        private System.Timers.Timer timer;

        public FormHatirlatici()
        {
            InitializeComponent();
        }

        private void FormHatirlatici_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }


        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime kullaniciTime = dateTimePicker1.Value;

            if (currentTime.Hour == kullaniciTime.Hour && currentTime.Minute == kullaniciTime.Minute && currentTime.Second == kullaniciTime.Second)
            {
                timer.Stop();
                MessageBox.Show(" Su İçme Zamanı! ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblDurum.Text = "Stop";
        }

        private void btnAlarmKur_Click_1(object sender, EventArgs e)
        {
            timer.Start();
            lblDurum.Text = "Running";
        }
    }
}
