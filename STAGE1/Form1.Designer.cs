namespace STAGE1
{
    partial class STAGE1Frame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VillainHPbar = new System.Windows.Forms.ProgressBar();
            this.Villainavatar = new System.Windows.Forms.PictureBox();
            this.char1avatar = new System.Windows.Forms.PictureBox();
            this.Char1HPbar = new System.Windows.Forms.ProgressBar();
            this.Char2HPbar = new System.Windows.Forms.ProgressBar();
            this.char2avatar = new System.Windows.Forms.PictureBox();
            this.char3avatar = new System.Windows.Forms.PictureBox();
            this.Char3HPbar = new System.Windows.Forms.ProgressBar();
            this.HealthTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.BackgroundPB = new System.Windows.Forms.PictureBox();
            this.DamageTimer = new System.Windows.Forms.Timer(this.components);
            this.BossAttack = new System.Windows.Forms.Timer(this.components);
            this.DamageLabel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Villainavatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tag = "tmr";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VillainHPbar
            // 
            this.VillainHPbar.Location = new System.Drawing.Point(171, 347);
            this.VillainHPbar.Maximum = 1000;
            this.VillainHPbar.Name = "VillainHPbar";
            this.VillainHPbar.Size = new System.Drawing.Size(481, 15);
            this.VillainHPbar.TabIndex = 3;
            this.VillainHPbar.Value = 1000;
            // 
            // Villainavatar
            // 
            this.Villainavatar.Image = global::STAGE1.Properties.Resources.b1;
            this.Villainavatar.Location = new System.Drawing.Point(696, 324);
            this.Villainavatar.Name = "Villainavatar";
            this.Villainavatar.Size = new System.Drawing.Size(96, 65);
            this.Villainavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Villainavatar.TabIndex = 8;
            this.Villainavatar.TabStop = false;
            // 
            // char1avatar
            // 
            this.char1avatar.Image = global::STAGE1.Properties.Resources.h1_off;
            this.char1avatar.Location = new System.Drawing.Point(1, 338);
            this.char1avatar.Name = "char1avatar";
            this.char1avatar.Size = new System.Drawing.Size(73, 51);
            this.char1avatar.TabIndex = 0;
            this.char1avatar.TabStop = false;
            // 
            // Char1HPbar
            // 
            this.Char1HPbar.ForeColor = System.Drawing.Color.Maroon;
            this.Char1HPbar.Location = new System.Drawing.Point(1, 325);
            this.Char1HPbar.Name = "Char1HPbar";
            this.Char1HPbar.Size = new System.Drawing.Size(72, 14);
            this.Char1HPbar.Step = 100;
            this.Char1HPbar.TabIndex = 4;
            this.Char1HPbar.Value = 100;
            // 
            // Char2HPbar
            // 
            this.Char2HPbar.Location = new System.Drawing.Point(75, 325);
            this.Char2HPbar.Name = "Char2HPbar";
            this.Char2HPbar.Size = new System.Drawing.Size(72, 14);
            this.Char2HPbar.TabIndex = 9;
            this.Char2HPbar.Value = 100;
            // 
            // char2avatar
            // 
            this.char2avatar.Image = global::STAGE1.Properties.Resources.h2_off;
            this.char2avatar.Location = new System.Drawing.Point(75, 338);
            this.char2avatar.Name = "char2avatar";
            this.char2avatar.Size = new System.Drawing.Size(73, 51);
            this.char2avatar.TabIndex = 1;
            this.char2avatar.TabStop = false;
            // 
            // char3avatar
            // 
            this.char3avatar.Image = global::STAGE1.Properties.Resources.h3_off;
            this.char3avatar.Location = new System.Drawing.Point(149, 338);
            this.char3avatar.Name = "char3avatar";
            this.char3avatar.Size = new System.Drawing.Size(73, 51);
            this.char3avatar.TabIndex = 2;
            this.char3avatar.TabStop = false;
            // 
            // Char3HPbar
            // 
            this.Char3HPbar.Location = new System.Drawing.Point(150, 325);
            this.Char3HPbar.Name = "Char3HPbar";
            this.Char3HPbar.Size = new System.Drawing.Size(72, 14);
            this.Char3HPbar.TabIndex = 10;
            this.Char3HPbar.Value = 100;
            // 
            // HealthTimer
            // 
            this.HealthTimer.Enabled = true;
            this.HealthTimer.Interval = 1;
            this.HealthTimer.Tag = "tmr";
            this.HealthTimer.Tick += new System.EventHandler(this.HealthTimer_Tick);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Timer.Location = new System.Drawing.Point(354, 5);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(105, 53);
            this.Timer.TabIndex = 16;
            this.Timer.Text = "5:00";
            // 
            // BackgroundPB
            // 
            this.BackgroundPB.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPB.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPB.Name = "BackgroundPB";
            this.BackgroundPB.Size = new System.Drawing.Size(794, 391);
            this.BackgroundPB.TabIndex = 17;
            this.BackgroundPB.TabStop = false;
            // 
            // DamageTimer
            // 
            this.DamageTimer.Enabled = true;
            this.DamageTimer.Interval = 200;
            this.DamageTimer.Tag = "tmr";
            this.DamageTimer.Tick += new System.EventHandler(this.DamageTimer_Tick);
            // 
            // BossAttack
            // 
            this.BossAttack.Enabled = true;
            this.BossAttack.Interval = 1200;
            this.BossAttack.Tag = "tmr";
            this.BossAttack.Tick += new System.EventHandler(this.BossAttack_Tick);
            // 
            // DamageLabel
            // 
            this.DamageLabel.Enabled = true;
            this.DamageLabel.Interval = 500;
            this.DamageLabel.Tag = "tmr";
            this.DamageLabel.Tick += new System.EventHandler(this.DamageLabel_Tick);
            // 
            // STAGE1Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STAGE1.Properties.Resources.backs1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.VillainHPbar);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Char3HPbar);
            this.Controls.Add(this.Char2HPbar);
            this.Controls.Add(this.Villainavatar);
            this.Controls.Add(this.Char1HPbar);
            this.Controls.Add(this.char3avatar);
            this.Controls.Add(this.char2avatar);
            this.Controls.Add(this.char1avatar);
            this.Controls.Add(this.BackgroundPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "STAGE1Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triple Threat";
            this.Load += new System.EventHandler(this.STAGE1Frame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.STAGE1Frame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.STAGE1Frame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Villainavatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar VillainHPbar;
        private System.Windows.Forms.PictureBox Villainavatar;
        private System.Windows.Forms.PictureBox char1avatar;
        private System.Windows.Forms.ProgressBar Char1HPbar;
        private System.Windows.Forms.ProgressBar Char2HPbar;
        private System.Windows.Forms.PictureBox char2avatar;
        private System.Windows.Forms.PictureBox char3avatar;
        private System.Windows.Forms.ProgressBar Char3HPbar;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.PictureBox BackgroundPB;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer HealthTimer;
        public System.Windows.Forms.Timer DamageTimer;
        public System.Windows.Forms.Timer BossAttack;
        public System.Windows.Forms.Timer DamageLabel;
    }
}

