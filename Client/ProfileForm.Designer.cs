namespace Client
{
    partial class ProfileForm
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
            this.playerTitleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.numOfGamesLabel = new System.Windows.Forms.Label();
            this.numOfGamesTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerTitleLabel
            // 
            this.playerTitleLabel.AutoSize = true;
            this.playerTitleLabel.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerTitleLabel.Location = new System.Drawing.Point(201, 83);
            this.playerTitleLabel.Name = "playerTitleLabel";
            this.playerTitleLabel.Size = new System.Drawing.Size(354, 72);
            this.playerTitleLabel.TabIndex = 0;
            this.playerTitleLabel.Text = "Player Profile";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(93, 267);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 45);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLabel.Location = new System.Drawing.Point(93, 385);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(104, 45);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(93, 499);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(168, 45);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(396, 273);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 31);
            this.nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(396, 391);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(243, 31);
            this.emailTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(396, 505);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(243, 31);
            this.passwordTextBox.TabIndex = 6;
            // 
            // numOfGamesLabel
            // 
            this.numOfGamesLabel.AutoSize = true;
            this.numOfGamesLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold);
            this.numOfGamesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numOfGamesLabel.Location = new System.Drawing.Point(93, 607);
            this.numOfGamesLabel.Name = "numOfGamesLabel";
            this.numOfGamesLabel.Size = new System.Drawing.Size(248, 45);
            this.numOfGamesLabel.TabIndex = 7;
            this.numOfGamesLabel.Text = "Num of Games";
            // 
            // numOfGamesTextBox
            // 
            this.numOfGamesTextBox.Location = new System.Drawing.Point(396, 613);
            this.numOfGamesTextBox.Name = "numOfGamesTextBox";
            this.numOfGamesTextBox.ReadOnly = true;
            this.numOfGamesTextBox.Size = new System.Drawing.Size(243, 31);
            this.numOfGamesTextBox.TabIndex = 8;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.GhostWhite;
            this.updateButton.Location = new System.Drawing.Point(164, 785);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(205, 81);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(396, 785);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(205, 81);
            this.close_button.TabIndex = 10;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(92)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(794, 946);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.numOfGamesTextBox);
            this.Controls.Add(this.numOfGamesLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.playerTitleLabel);
            this.Name = "ProfileForm";
            this.Text = "Player Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerTitleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label numOfGamesLabel;
        private System.Windows.Forms.TextBox numOfGamesTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button close_button;
    }
}