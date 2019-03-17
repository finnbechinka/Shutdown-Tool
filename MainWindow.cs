using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTool
{
    public partial class stdwntool : Form
    {
        //6l for window drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Timer timer = new Timer();
        private int t;
        public stdwntool()
        {
            InitializeComponent();
        }

        private void execShutdown(string arguments)
        {
            Process tmp = new Process();
            tmp.StartInfo.FileName = "shutdown";
            tmp.StartInfo.Arguments = arguments;
            tmp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            tmp.Start();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            execShutdown("-a");
            timer.Stop();
            this.Dispose();
            this.Close();
        }

        private void bExec_Click(object sender, EventArgs e)
        {
            exec();
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                exec();
        }

        private void exec()
        {
            execShutdown("-a");
            if (this.tbInput.TextLength > 0)
            {
                double input = (double.Parse(this.tbInput.Text) * 60) * 60;
                execShutdown("-s -t " + input);
                timerStart(input);
            }
        }

        private void timerStart(double time)
        {
            t = Convert.ToInt32(time);
            timer1.Stop();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0) {
                t--;
                int hrs = (t / 60) / 60;
                int min = (t / 60) % 60;
                if (min < 10)
                {
                    tbCountdown.Font = new Font(tbCountdown.Font, FontStyle.Bold);
                    tbCountdown.ForeColor = Color.Red;
                }
                int sec = t % 60;
                tbCountdown.Text = string.Format("{0}:{1}:{2}", hrs, min, sec);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void stdwntool_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
