using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private DateTime StartTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds / 100;

            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + "." +
                tenths.ToString("0");

            Txt_Result.Text = text;
        }

        void Start()
        {
            tmrClock.Enabled = true;
        }
     
        void Stop()
        {
            tmrClock.Enabled = false;
        }

        void Reset()
        {
            Txt_Result.Text = "";
        }
    }
}
