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
            int x = 650;
            int z = 0;
            int y = 300;
            pictureBox1.Visible = false;
            titleLabel.Visible = false;
            titleLabel2.Visible = false;

            Graphics fg = this.CreateGraphics();
            Font missionFont = new Font("Consolas", 14, FontStyle.Bold);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen1 = new Pen(Color.FromArgb(255, 255, 255, 255), 30);
            Pen whitePen2 = new Pen(Color.FromArgb(255, 255, 255, 255), 1);
            Pen blackPen = new Pen(Color.Black);

            fg.DrawString("Recieved Transmisson...", missionFont, greenBrush, 10, 40);
            fg.DrawString("The Death Star has a exhast port that can be breached.", missionFont, greenBrush, 10, 80);
            fg.DrawString("Your mission is to put a proton torpedo into the exhast port.", missionFont, greenBrush, 10, 100);
            fg.DrawString("Good luck rookie!!", missionFont, greenBrush, 10, 140);

            Thread.Sleep(5000);

            fg.Clear(Color.Black);

            // for (x = 600; x <= this.Width; x--)
            while (x >= -20)
            {
                //act
                fg.Clear(Color.Black);
                fg.FillRectangle(whiteBrush, x, 300, 20, 20);
                fg.DrawLine(whitePen1, 0, 415, 285, 415);
                fg.DrawLine(whitePen1, 385, 415, 800, 415);
                Thread.Sleep(5);
                x--;

                if (x == 440)
                {
                    z = 1;
                }
                if (z == 1)
                {
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, x, 300, 20, 20);
                    fg.FillEllipse(whiteBrush, x, y, 10, 10);
                    fg.DrawLine(whitePen1, 0, 415, 285, 415);
                    fg.DrawLine(whitePen1, 385, 415, 800, 415);
                    y++;
                }
                fg.Clear(Color.Black);
            }
            for (y = 0; y <= 255; y++)
            {
                fg.Clear(Color.Black);
                fg.DrawLine(whitePen2, 326, 0, 326, 250);
                fg.DrawEllipse(whitePen2, 298, 250, 55, 55);
                fg.FillEllipse(whiteBrush, 317, y, 20, 20);
                Thread.Sleep(5);

                if (y == 255)
                {
                    
                }
            }
        }
    }
}
   

 


