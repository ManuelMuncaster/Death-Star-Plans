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
using System.Media;

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
            double y2 = 0;
            int y3 = 0;

            pictureBox1.Visible = false;
            titleLabel.Visible = false;
            titleLabel2.Visible = false;

            SoundPlayer player1 = new SoundPlayer(Properties.Resources.Proton);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Explosion);

            Graphics fg = this.CreateGraphics();
            Font missionFont = new Font("Consolas", 14, FontStyle.Bold);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen whitePen1 = new Pen(Color.FromArgb(255, 255, 255, 255), 30);
            Pen whitePen2 = new Pen(Color.FromArgb(255, 255, 255, 255), 1);
            Pen blackPen = new Pen(Color.Black);

            fg.DrawString("Recieved Transmission...", missionFont, greenBrush, 10, 40);
            fg.DrawString("The Death Star is heavily shielded and carries a \r\nfirepower greater than half the star fleet.", missionFont, greenBrush, 10, 80);
            fg.DrawString("It's defenses are designed around a direct large - scale \r\nassault.", missionFont, greenBrush, 10, 125);
            fg.DrawString("A small one-man fighter should be able to penetrate", missionFont, greenBrush, 100, 147);
            fg.DrawString("the outer defence.", missionFont, greenBrush, 10, 170);
            fg.DrawString("The target area is only two meters wide.", missionFont, greenBrush, 203, 170);
            fg.DrawString("It's a small thermal exhaust port, right below the main port.", missionFont, greenBrush, 10, 190);
            fg.DrawString("The shaft leads directly to the reactor system.", missionFont, greenBrush, 10, 212);
            fg.DrawString("A precise hit", missionFont, greenBrush, 510, 212);
            fg.DrawString("will start a chain reaction which should destroy the station.", missionFont, greenBrush, 10, 235);
            fg.DrawString("Good luck rookie!!!", missionFont, greenBrush, 10, 275);
            Thread.Sleep(15000);

            fg.Clear(Color.Black);
                

            fg.DrawEllipse(whitePen2, 130, 20, 400, 400);
            fg.DrawEllipse(whitePen2, 200, 65, 100, 100);
            fg.DrawEllipse(whitePen2, 223, 86, 50, 50);

            Thread.Sleep(5000);

            fg.Clear(Color.Black);

            while (x >= -20)
            {
                fg.Clear(Color.Black);
                fg.FillRectangle(whiteBrush, x, 300, 20, 20);
                fg.DrawLine(whitePen1, 0, 415, 285, 415);
                fg.DrawLine(whitePen1, 385, 415, 800, 415);
                Thread.Sleep(5);
                x--;

                if (x == 400)
                {
                    z = 1;
                    player1.Play();
                }
                if (z == 1)
                {
                    fg.Clear(Color.Black);
                    fg.FillRectangle(whiteBrush, x, 300, 20, 20);

                    y2 = (x * x * 0.018) - (14.22 * x) + 3144;
                    y3 = Convert.ToInt32(y2);
                    fg.FillEllipse(whiteBrush, x, y3, 10, 10);
                    fg.DrawLine(whitePen1, 0, 415, 285, 415);
                    fg.DrawLine(whitePen1, 385, 415, 800, 415);
                    y++;
                }
                fg.Clear(Color.Black);
            }
            for (y = 0; y <= 260; y++)
            {
                fg.Clear(Color.Black);
                fg.DrawLine(whitePen2, 326, 0, 326, 245);
                fg.DrawEllipse(whitePen2, 304, 245, 44, 44);
                fg.FillEllipse(whiteBrush, 317, y, 20, 20);
                Thread.Sleep(5);

                if (y == 260)
                {
                    z = 25;
                    player2.Play();
                }
                if (z == 25)
                {
                    for (z = 25; z >= 1; z-- )
                    {
                        fg.TranslateTransform(100.0F, 0.0F);
                        fg.FillRectangle(whiteBrush, 217, 148, 20, 135);
                        fg.FillRectangle(whiteBrush, 217, 248, 20, 135);
                        fg.FillRectangle(whiteBrush, 117, 260, 235, 20);
                        fg.RotateTransform(45.0F);
                        fg.FillRectangle(whiteBrush, 339, -95, 20, 250);
                        fg.RotateTransform(-90.0F);
                        fg.FillRectangle(whiteBrush, -38, 225, 20, 250);
                        Thread.Sleep(85);

                        fg.ResetTransform();
                        fg.TranslateTransform(100.0F, 0.0F);
                        fg.FillRectangle(blackBrush, 217, 148, 20, 135);
                        fg.FillRectangle(blackBrush, 217, 248, 20, 135);
                        fg.FillRectangle(blackBrush, 117, 260, 235, 20);
                        fg.RotateTransform(45.0F, 0.0F);
                        fg.FillRectangle(blackBrush, 339, -95, 20, 250);
                        fg.RotateTransform(-90.0F);
                        fg.FillRectangle(blackBrush, -38, 225, 20, 250);
                        fg.ResetTransform();
                        Thread.Sleep(85);

                        fg.DrawLine(whitePen2, 326, 0, 326, 245);
                        fg.DrawEllipse(whitePen2, 304, 245, 44, 44);
                        fg.FillEllipse(whiteBrush, 315, y, 20, 20);
                    }
                    fg.Clear(Color.Black);

                    fg.DrawString("Good job!!! You blew up the Death Star!", missionFont, greenBrush, 10, 40);

                    Thread.Sleep(3000);

                    Application.Exit();
                }
            }
        }
    }
}
   

 


