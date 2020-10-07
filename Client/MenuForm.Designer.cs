namespace Client
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.profileButton, "profileButton");
            this.profileButton.Name = "profileButton";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.historyButton, "historyButton");
            this.historyButton.Name = "historyButton";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.gameButton, "gameButton");
            this.gameButton.Name = "gameButton";
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(92)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button gameButton;
    }
}