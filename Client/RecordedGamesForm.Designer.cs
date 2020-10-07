namespace Client
{
    partial class RecordedGamesForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.chooseTitlelabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(158, 47);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(785, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "List of Your Recorded Games";
            // 
            // gamesListBox
            // 
            this.gamesListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.ItemHeight = 39;
            this.gamesListBox.Location = new System.Drawing.Point(334, 308);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(401, 394);
            this.gamesListBox.TabIndex = 1;
            this.gamesListBox.SelectedIndexChanged += new System.EventHandler(this.gamesListBox_SelectedIndexChanged);
            // 
            // chooseTitlelabel
            // 
            this.chooseTitlelabel.AutoSize = true;
            this.chooseTitlelabel.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTitlelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseTitlelabel.Location = new System.Drawing.Point(328, 199);
            this.chooseTitlelabel.Name = "chooseTitlelabel";
            this.chooseTitlelabel.Size = new System.Drawing.Size(407, 53);
            this.chooseTitlelabel.TabIndex = 2;
            this.chooseTitlelabel.Text = "Choose Game By Date";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightGreen;
            this.playButton.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(411, 778);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(235, 89);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // RecordedGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(92)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1090, 965);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.chooseTitlelabel);
            this.Controls.Add(this.gamesListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "RecordedGamesForm";
            this.Text = "HistoricalGamesForm";
            this.Load += new System.EventHandler(this.HistoricalGamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox gamesListBox;
        private System.Windows.Forms.Label chooseTitlelabel;
        private System.Windows.Forms.Button playButton;
    }
}