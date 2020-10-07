namespace Client
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gameTitle = new System.Windows.Forms.Label();
            this.boardBox = new System.Windows.Forms.PictureBox();
            this.playerNameTitle = new System.Windows.Forms.Label();
            this.eatenTimer = new System.Windows.Forms.Timer(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Calibri", 36F);
            this.gameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameTitle.Location = new System.Drawing.Point(262, 37);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(605, 117);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Damka Game!";
            // 
            // boardBox
            // 
            this.boardBox.Location = new System.Drawing.Point(373, 225);
            this.boardBox.Margin = new System.Windows.Forms.Padding(4);
            this.boardBox.Name = "boardBox";
            this.boardBox.Size = new System.Drawing.Size(514, 804);
            this.boardBox.TabIndex = 2;
            this.boardBox.TabStop = false;
            this.boardBox.Click += new System.EventHandler(this.boardBox_Click);
            // 
            // playerNameTitle
            // 
            this.playerNameTitle.AutoSize = true;
            this.playerNameTitle.Location = new System.Drawing.Point(468, 140);
            this.playerNameTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerNameTitle.Name = "playerNameTitle";
            this.playerNameTitle.Size = new System.Drawing.Size(0, 25);
            this.playerNameTitle.TabIndex = 3;
            // 
            // eatenTimer
            // 
            this.eatenTimer.Tick += new System.EventHandler(this.eatenTimer_Tick);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(398, 1069);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(215, 72);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreTitleLabel.Location = new System.Drawing.Point(282, 158);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(114, 45);
            this.scoreTitleLabel.TabIndex = 5;
            this.scoreTitleLabel.Text = "Score:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(390, 158);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(39, 45);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(642, 1069);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(215, 72);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.refresh_button.Location = new System.Drawing.Point(792, 158);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(43, 45);
            this.refresh_button.TabIndex = 8;
            this.refresh_button.Text = "refreshButton";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // GameForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1148, 1212);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreTitleLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.playerNameTitle);
            this.Controls.Add(this.boardBox);
            this.Controls.Add(this.gameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.PictureBox boardBox;
        private System.Windows.Forms.Label playerNameTitle;
        private System.Windows.Forms.Timer eatenTimer;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refresh_button;
    }
}