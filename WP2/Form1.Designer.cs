namespace WP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtAmmo = new Label();
            txtScore = new Label();
            txtHealth = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.BackColor = Color.FromArgb(64, 64, 64);
            txtAmmo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = Color.White;
            txtAmmo.Location = new Point(12, 9);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(83, 22);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.FromArgb(64, 64, 64);
            txtScore.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(422, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(67, 22);
            txtScore.TabIndex = 1;
            txtScore.Text = "Kills: 0";
            // 
            // txtHealth
            // 
            txtHealth.AutoSize = true;
            txtHealth.BackColor = Color.FromArgb(64, 64, 64);
            txtHealth.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHealth.ForeColor = Color.White;
            txtHealth.Location = new Point(678, 9);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(69, 22);
            txtHealth.TabIndex = 2;
            txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(744, 8);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(175, 23);
            healthBar.TabIndex = 3;
            healthBar.Value = 100;
            // 
            // player
            // 
            player.Image = Game.Properties.Resources.up;
            player.Location = new Point(418, 498);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(924, 661);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(txtHealth);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zombie Shootout Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAmmo;
        private Label txtScore;
        private Label txtHealth;
        private ProgressBar healthBar;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}
