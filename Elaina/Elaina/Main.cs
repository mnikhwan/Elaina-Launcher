using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elaina
{
    public partial class Main : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/rgE3FXB");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/oauth2/authorize?client_id=765085399944658944&scope=bot&permissions=2146827639");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://elainabot.xyz/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElainaLaunch3r sf = new ElainaLaunch3r();
            sf.Show();
        }
    }
}
