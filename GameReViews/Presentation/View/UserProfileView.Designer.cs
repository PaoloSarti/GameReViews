namespace GameReViews
{
    partial class UserProfileView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._userInfoContainer_root = new System.Windows.Forms.Panel();
            this._userInfoContainer = new System.Windows.Forms.Panel();
            this._customDataGridView = new GameReViews.CustomDataGridView();
            this._preferenzeControlPanel = new System.Windows.Forms.Panel();
            this._aggiungiPreferenza = new System.Windows.Forms.Button();
            this._preferenzeLabel = new System.Windows.Forms.Label();
            this._userInfoPanel = new System.Windows.Forms.Panel();
            this._logoutButton = new System.Windows.Forms.Button();
            this.circularPictureBox1 = new CircularPictureBox();
            this._userName = new System.Windows.Forms.Label();
            this._userInfoContainer_root.SuspendLayout();
            this._userInfoContainer.SuspendLayout();
            this._preferenzeControlPanel.SuspendLayout();
            this._userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _userInfoContainer_root
            // 
            this._userInfoContainer_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this._userInfoContainer_root.Controls.Add(this._userInfoContainer);
            this._userInfoContainer_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this._userInfoContainer_root.Location = new System.Drawing.Point(0, 0);
            this._userInfoContainer_root.Name = "_userInfoContainer_root";
            this._userInfoContainer_root.Size = new System.Drawing.Size(883, 619);
            this._userInfoContainer_root.TabIndex = 0;
            // 
            // _userInfoContainer
            // 
            this._userInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._userInfoContainer.BackColor = System.Drawing.Color.White;
            this._userInfoContainer.Controls.Add(this._customDataGridView);
            this._userInfoContainer.Controls.Add(this._preferenzeControlPanel);
            this._userInfoContainer.Controls.Add(this._userInfoPanel);
            this._userInfoContainer.Location = new System.Drawing.Point(17, 0);
            this._userInfoContainer.Name = "_userInfoContainer";
            this._userInfoContainer.Size = new System.Drawing.Size(849, 619);
            this._userInfoContainer.TabIndex = 3;
            // 
            // _customDataGridView
            // 
            this._customDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customDataGridView.Location = new System.Drawing.Point(0, 312);
            this._customDataGridView.Name = "_customDataGridView";
            this._customDataGridView.Size = new System.Drawing.Size(849, 307);
            this._customDataGridView.TabIndex = 6;
            // 
            // _preferenzeControlPanel
            // 
            this._preferenzeControlPanel.Controls.Add(this._aggiungiPreferenza);
            this._preferenzeControlPanel.Controls.Add(this._preferenzeLabel);
            this._preferenzeControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._preferenzeControlPanel.Location = new System.Drawing.Point(0, 234);
            this._preferenzeControlPanel.Name = "_preferenzeControlPanel";
            this._preferenzeControlPanel.Size = new System.Drawing.Size(849, 78);
            this._preferenzeControlPanel.TabIndex = 5;
            // 
            // _aggiungiPreferenza
            // 
            this._aggiungiPreferenza.BackColor = System.Drawing.Color.Silver;
            this._aggiungiPreferenza.FlatAppearance.BorderSize = 0;
            this._aggiungiPreferenza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._aggiungiPreferenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._aggiungiPreferenza.ForeColor = System.Drawing.Color.White;
            this._aggiungiPreferenza.Location = new System.Drawing.Point(368, 9);
            this._aggiungiPreferenza.Name = "_aggiungiPreferenza";
            this._aggiungiPreferenza.Size = new System.Drawing.Size(250, 57);
            this._aggiungiPreferenza.TabIndex = 1;
            this._aggiungiPreferenza.Text = "Aggiungi preferenza";
            this._aggiungiPreferenza.UseVisualStyleBackColor = false;
            this._aggiungiPreferenza.Click += new System.EventHandler(this._aggiungiPreferenza_Click);
            // 
            // _preferenzeLabel
            // 
            this._preferenzeLabel.AutoSize = true;
            this._preferenzeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._preferenzeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._preferenzeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._preferenzeLabel.Location = new System.Drawing.Point(0, 0);
            this._preferenzeLabel.Name = "_preferenzeLabel";
            this._preferenzeLabel.Padding = new System.Windows.Forms.Padding(90, 25, 50, 0);
            this._preferenzeLabel.Size = new System.Drawing.Size(267, 50);
            this._preferenzeLabel.TabIndex = 0;
            this._preferenzeLabel.Text = "Preferenze";
            // 
            // _userInfoPanel
            // 
            this._userInfoPanel.Controls.Add(this._logoutButton);
            this._userInfoPanel.Controls.Add(this.circularPictureBox1);
            this._userInfoPanel.Controls.Add(this._userName);
            this._userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._userInfoPanel.Location = new System.Drawing.Point(0, 0);
            this._userInfoPanel.Name = "_userInfoPanel";
            this._userInfoPanel.Padding = new System.Windows.Forms.Padding(25, 10, 8, 10);
            this._userInfoPanel.Size = new System.Drawing.Size(849, 234);
            this._userInfoPanel.TabIndex = 3;
            // 
            // _logoutButton
            // 
            this._logoutButton.BackColor = System.Drawing.Color.Silver;
            this._logoutButton.FlatAppearance.BorderSize = 0;
            this._logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this._logoutButton.ForeColor = System.Drawing.Color.White;
            this._logoutButton.Location = new System.Drawing.Point(368, 126);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(250, 57);
            this._logoutButton.TabIndex = 3;
            this._logoutButton.Text = "Logout";
            this._logoutButton.UseVisualStyleBackColor = false;
            this._logoutButton.Click += new System.EventHandler(this._logoutButton_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Purple;
            this.circularPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.circularPictureBox1.Image = global::GameReViews.Properties.Resources.nonsensCapture;
            this.circularPictureBox1.Location = new System.Drawing.Point(25, 10);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(245, 214);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
            // 
            // _userName
            // 
            this._userName.AutoSize = true;
            this._userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userName.Location = new System.Drawing.Point(361, 48);
            this._userName.Name = "_userName";
            this._userName.Size = new System.Drawing.Size(112, 39);
            this._userName.TabIndex = 1;
            this._userName.Text = "Nome";
            // 
            // UserProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._userInfoContainer_root);
            this.Name = "UserProfileView";
            this.Size = new System.Drawing.Size(883, 619);
            this._userInfoContainer_root.ResumeLayout(false);
            this._userInfoContainer.ResumeLayout(false);
            this._preferenzeControlPanel.ResumeLayout(false);
            this._preferenzeControlPanel.PerformLayout();
            this._userInfoPanel.ResumeLayout(false);
            this._userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _userInfoContainer_root;
        private System.Windows.Forms.Label _userName;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel _userInfoContainer;
        private System.Windows.Forms.Panel _userInfoPanel;
        private System.Windows.Forms.Panel _preferenzeControlPanel;
        private System.Windows.Forms.Button _aggiungiPreferenza;
        private System.Windows.Forms.Label _preferenzeLabel;
        private CustomDataGridView _customDataGridView;
        private System.Windows.Forms.Button _logoutButton;
    }
}
