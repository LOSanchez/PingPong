using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        bool goup; 
        bool godown; 
        int speed = 5; 
        int ballx = 5; 
        int bally = 5; 
        int score = 0; 
        int cpuScore = 0; 
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }
        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score; 
            cpuLabel.Text = "" + cpuScore; 
            ball.Top -= bally; 
            ball.Left -= ballx; 
            cpu.Top += speed; 
                            
            if (score < 5)
            {
                
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                            speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top;
            }

 
            if (ball.Left < 0)
            {

                ball.Left = 434; 
                ballx = -ballx; 
                ballx -= 2; 
                cpuScore++;
            }
            
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434; 
                ballx = -ballx; 
                ballx += 2; 
                score++; 
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }

            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }

            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }
        }
    }
}
