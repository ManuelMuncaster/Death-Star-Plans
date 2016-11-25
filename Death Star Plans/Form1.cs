using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Death_Star_Plans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            titleLabel.Visible = false;
            titleLabel2.Visible = false;

            Graphics fg = this.CreateGraphics();
            Font missionFont = new Font("Consolas", 14, FontStyle.Bold);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White);

            fg.DrawString("Recieved Transmisson...", missionFont, greenBrush, 10, 40);
            fg.DrawString("The Death Star has a exhast port that can be breached.", missionFont, greenBrush, 10, 80);
            fg.DrawString("Your mission is to put a proton torpedo into the exhast port.", missionFont, greenBrush, 10, 100);
            fg.DrawString("Good luck rookie!!", missionFont, greenBrush, 10, 140);

            Thread.Sleep(5000);

            fg.Clear(Color.Black);

            fg.FillRectangle(whiteBrush, 25, 25, 100, 200);
            //fg.DrawEllipse(whitePen, 200, 100, 300, 300);

        }
    }
}
