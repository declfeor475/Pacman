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

/// <summary>
/// Created by Declan Feore
/// September 2019
/// Basic animation and sounds
/// </summary>
namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //graphics setting
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Comic Sans", 16);
            SolidBrush titleBrush = new SolidBrush(Color.BlueViolet);

            g.Clear(Color.Black);
            g.DrawString("Player 1", titleFont, titleBrush, 240, 50);
            g.DrawString("Click Anywhere", titleFont, titleBrush, 210, 100);
            //
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pathPen = new Pen(Color.Blue, 7);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);
            SoundPlayer beginSound = new SoundPlayer(Properties.Resources.begin);
            SoundPlayer chompSound = new SoundPlayer(Properties.Resources.chomp);

            //begin sound
            beginSound.Play();
            
            //frame 1
            g.Clear(Color.Black);
            Thread.Sleep(4000);
            g.DrawLine(pathPen, 40, 60, 280, 60);
            g.DrawLine(pathPen, 40, 120, 200, 120); 
            g.DrawLine(pathPen, 280, 60, 280, 200);
            g.DrawLine(pathPen, 200, 120, 200, 200);
            g.FillPie(pacBrush, 40, 75, 30, 30, 30, 300);

            Thread.Sleep(1000);

            //frame 2
            g.Clear(Color.Black);
            g.DrawLine(pathPen, 40, 60, 280, 60);
            g.DrawLine(pathPen, 40, 120, 200, 120);
            g.DrawLine(pathPen, 280, 60, 280, 200);
            g.DrawLine(pathPen, 200, 120, 200, 200);
            chompSound.Play();
            g.FillEllipse(pacBrush, 80, 75, 30, 30);

            Thread.Sleep(1000);

            //frame 3
            g.Clear(Color.Black);
            g.DrawLine(pathPen, 40, 60, 280, 60);
            g.DrawLine(pathPen, 40, 120, 200, 120);
            g.DrawLine(pathPen, 280, 60, 280, 200);
            g.DrawLine(pathPen, 200, 120, 200, 200);
            g.FillPie(pacBrush, 120, 75, 30, 30, 30, 300); 

        }
    }
}
