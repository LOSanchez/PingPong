using System;

namespace PingPong
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu.Location = new System.Drawing.Point(897, 230);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 2;
            this.cpu.TabStop = false;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(32, 24);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuLabel.Location = new System.Drawing.Point(735, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(38, 25);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "ll";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}
#endregion