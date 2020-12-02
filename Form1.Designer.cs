namespace StarShipBattelsXI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ControlsLabel = new System.Windows.Forms.Label();
            this.starFieldBackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.HardLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.ControlDescriptionLabel = new System.Windows.Forms.Label();
            this.OKLabel = new System.Windows.Forms.Label();
            this.HighestScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.starFieldBackgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("04b_19", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.MainLabel.Location = new System.Drawing.Point(159, 180);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(690, 64);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "STAR SHIP BATTLES XI";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.StartLabel.Location = new System.Drawing.Point(428, 303);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(152, 38);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "START";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartLabel.Click += new System.EventHandler(this.StartLabel_Click);
            this.StartLabel.MouseEnter += new System.EventHandler(this.StartLabel_MouseEnter);
            this.StartLabel.MouseLeave += new System.EventHandler(this.StartLabel_MouseLeave);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModeLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.ModeLabel.Location = new System.Drawing.Point(442, 360);
            this.ModeLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(125, 38);
            this.ModeLabel.TabIndex = 2;
            this.ModeLabel.Text = "MODE";
            this.ModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModeLabel.Click += new System.EventHandler(this.ModeLabel_Click);
            this.ModeLabel.MouseEnter += new System.EventHandler(this.ModeLabel_MouseEnter);
            this.ModeLabel.MouseLeave += new System.EventHandler(this.ModeLabel_MouseLeave);
            // 
            // ControlsLabel
            // 
            this.ControlsLabel.AutoSize = true;
            this.ControlsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlsLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.ControlsLabel.Location = new System.Drawing.Point(388, 417);
            this.ControlsLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ControlsLabel.Name = "ControlsLabel";
            this.ControlsLabel.Size = new System.Drawing.Size(233, 38);
            this.ControlsLabel.TabIndex = 3;
            this.ControlsLabel.Text = "CONTROLS";
            this.ControlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlsLabel.Click += new System.EventHandler(this.ControlLabel_Click);
            this.ControlsLabel.MouseEnter += new System.EventHandler(this.ControlLabel_MouseEnter);
            this.ControlsLabel.MouseLeave += new System.EventHandler(this.ControlLabel_MouseLeave);
            // 
            // starFieldBackgroundPictureBox
            // 
            this.starFieldBackgroundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.starFieldBackgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.starFieldBackgroundPictureBox.Image = global::StarShipBattelsXI.Properties.Resources.starFieldBackgroundFIle;
            this.starFieldBackgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.starFieldBackgroundPictureBox.Name = "starFieldBackgroundPictureBox";
            this.starFieldBackgroundPictureBox.Size = new System.Drawing.Size(1008, 689);
            this.starFieldBackgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starFieldBackgroundPictureBox.TabIndex = 2;
            this.starFieldBackgroundPictureBox.TabStop = false;
            this.starFieldBackgroundPictureBox.Visible = false;
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.ExitLabel.Location = new System.Drawing.Point(442, 475);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(125, 38);
            this.ExitLabel.TabIndex = 4;
            this.ExitLabel.Text = "EXIT";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyLabel.Enabled = false;
            this.EasyLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.EasyLabel.Location = new System.Drawing.Point(442, 303);
            this.EasyLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(125, 38);
            this.EasyLabel.TabIndex = 8;
            this.EasyLabel.Text = "EASY";
            this.EasyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EasyLabel.Visible = false;
            this.EasyLabel.Click += new System.EventHandler(this.EasyLabel_Click);
            this.EasyLabel.MouseEnter += new System.EventHandler(this.EasyLabel_MouseEnter);
            this.EasyLabel.MouseLeave += new System.EventHandler(this.EasyLabel_MouseLeave);
            // 
            // HardLabel
            // 
            this.HardLabel.AutoSize = true;
            this.HardLabel.BackColor = System.Drawing.Color.Transparent;
            this.HardLabel.Enabled = false;
            this.HardLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.HardLabel.Location = new System.Drawing.Point(442, 417);
            this.HardLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(125, 38);
            this.HardLabel.TabIndex = 6;
            this.HardLabel.Text = "HARD";
            this.HardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HardLabel.Visible = false;
            this.HardLabel.Click += new System.EventHandler(this.HardLabel_Click);
            this.HardLabel.MouseEnter += new System.EventHandler(this.HardLabel_MouseEnter);
            this.HardLabel.MouseLeave += new System.EventHandler(this.HardLabel_MouseLeave);
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.BackColor = System.Drawing.Color.Transparent;
            this.MediumLabel.Enabled = false;
            this.MediumLabel.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.MediumLabel.Location = new System.Drawing.Point(415, 360);
            this.MediumLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(179, 38);
            this.MediumLabel.TabIndex = 7;
            this.MediumLabel.Text = "MEDIUM";
            this.MediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MediumLabel.Visible = false;
            this.MediumLabel.Click += new System.EventHandler(this.MediumLabel_Click);
            this.MediumLabel.MouseEnter += new System.EventHandler(this.MediumLabel_MouseEnter);
            this.MediumLabel.MouseLeave += new System.EventHandler(this.MediumLabel_MouseLeave);
            // 
            // ControlDescriptionLabel
            // 
            this.ControlDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlDescriptionLabel.Enabled = false;
            this.ControlDescriptionLabel.Font = new System.Drawing.Font("04b_19", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.ControlDescriptionLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ControlDescriptionLabel.Location = new System.Drawing.Point(215, 309);
            this.ControlDescriptionLabel.Name = "ControlDescriptionLabel";
            this.ControlDescriptionLabel.Size = new System.Drawing.Size(579, 180);
            this.ControlDescriptionLabel.TabIndex = 9;
            this.ControlDescriptionLabel.Text = "TO MOVE YOUR SHIP USE THE FOUR \'ARROW\' KEYS\r\n\r\nTO SHOOT WITH YOUR SHIP PRESS \'SPA" +
    "CE\' KEY\r\n\r\nYOU CAN NOT SHOOT MULTIPLE SHOTS\r\n\r\nWAIT FOR THE SHOT TO EXPLODE OR\r\n" +
    "DESAPPEAR BEFORE SHOOTING AGAIN";
            this.ControlDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ControlDescriptionLabel.Visible = false;
            // 
            // OKLabel
            // 
            this.OKLabel.AutoSize = true;
            this.OKLabel.BackColor = System.Drawing.Color.Transparent;
            this.OKLabel.Enabled = false;
            this.OKLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.OKLabel.Location = new System.Drawing.Point(469, 522);
            this.OKLabel.Name = "OKLabel";
            this.OKLabel.Size = new System.Drawing.Size(71, 38);
            this.OKLabel.TabIndex = 10;
            this.OKLabel.Text = "OK";
            this.OKLabel.Visible = false;
            this.OKLabel.Click += new System.EventHandler(this.OKLabel_Click);
            this.OKLabel.MouseEnter += new System.EventHandler(this.OKLabel_MouseEnter);
            this.OKLabel.MouseLeave += new System.EventHandler(this.OKLabel_MouseLeave);
            // 
            // HighestScoreLabel
            // 
            this.HighestScoreLabel.AutoSize = true;
            this.HighestScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.HighestScoreLabel.Enabled = false;
            this.HighestScoreLabel.Font = new System.Drawing.Font("04b_19", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(9)))));
            this.HighestScoreLabel.Location = new System.Drawing.Point(766, 557);
            this.HighestScoreLabel.Name = "HighestScoreLabel";
            this.HighestScoreLabel.Size = new System.Drawing.Size(197, 81);
            this.HighestScoreLabel.TabIndex = 11;
            this.HighestScoreLabel.Text = "HIGHEST SCORE\r\nSO FAR\r\n0";
            this.HighestScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HighestScoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::StarShipBattelsXI.Properties.Resources.starFieldBackgroundFIle;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.HighestScoreLabel);
            this.Controls.Add(this.OKLabel);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.ControlsLabel);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.EasyLabel);
            this.Controls.Add(this.HardLabel);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.starFieldBackgroundPictureBox);
            this.Controls.Add(this.ControlDescriptionLabel);
            this.Font = new System.Drawing.Font("3D Thirteen Pixel Fonts", 36F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAR SHIP BATTLES XI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starFieldBackgroundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label ControlsLabel;
        private System.Windows.Forms.PictureBox starFieldBackgroundPictureBox;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.Label HardLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Label ControlDescriptionLabel;
        private System.Windows.Forms.Label OKLabel;
        private System.Windows.Forms.Label HighestScoreLabel;
    }
}

