using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animatione
{
    public partial class Form1 : Form
    {
        private int ballWidth = 300;
        private int ballHeight = 300;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 4;
        private int moveStepY = 4;
        int milliseconds = 50;
        int BoundaryX = 727;
        int BoundaryY = 478;
        int vx = 1, vy = 1;
        

        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (Ball.Left > BoundaryX || Ball.Left <= 0)
            {
                vx *= -2; 
                // negative changes direction
            }

            if (Ball.Top <= 0)
            {
                vy *= -1;
            }

            if (Ball.Top > BoundaryY)
            {
                vy *= -1;
                vy += 0;        // after coliision with ground maximum height decreases each time
            }

            if (Ball.Left > BoundaryX)
            {
                vx *= 0;
                vx += -1;        // after coliision with ground maximum height decreases each time
            }
            vy++;               // ball is always attracted by gravity

            if (Ball.Top > BoundaryY) Ball.Top = BoundaryY;


            Ball.Left = Ball.Left + vx;
            Ball.Top = Ball.Top + vy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Ball.ForeColor = cd.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


    }

}


