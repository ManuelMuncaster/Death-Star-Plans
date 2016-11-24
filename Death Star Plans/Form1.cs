using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Font missionFont = new Font("Consolas", 16, FontStyle.Bold);
            SolidBrush greenBrush = new SolidBrush(Color.Green);

            fg.DrawString
        }
    }
}
