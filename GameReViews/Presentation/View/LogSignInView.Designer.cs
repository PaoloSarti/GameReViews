namespace GameReViews
{
    partial class LogSignInView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._loginButton = new System.Windows.Forms.Button();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._usernameTextBox = new System.Windows.Forms.TextBox();
            this._userNameLabel = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new CircularPictureBox();
            this._signinButton = new System.Windows.Forms.Button();
            this._userInfoContainer_root.SuspendLayout();
            this._userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this._userInfoContainer.Controls.Add(this.pictureBox1);
            this._userInfoContainer.Controls.Add(this._loginButton);
            this._userInfoContainer.Controls.Add(this._passwordTextBox);
            this._userInfoContainer.Controls.Add(this._passwordLabel);
            this._userInfoContainer.Controls.Add(this._usernameTextBox);
            this._userInfoContainer.Controls.Add(this._userNameLabel);
            this._userInfoContainer.Controls.Add(this.circularPictureBox1);
            this._userInfoContainer.Location = new System.Drawing.Point(17, 0);
            this._userInfoContainer.Name = "_userInfoContainer";
            this._userInfoContainer.Size = new System.Drawing.Size(849, 619);
            this._userInfoContainer.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameReViews.Properties.Resources.bubble42;
            this.pictureBox1.Location = new System.Drawing.Point(-57, 593);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1049, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _loginButton
            // 
            this._loginButton.BackColor = System.Drawing.Color.Silver;
            this._loginButton.FlatAppearance.BorderSize = 0;
            this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._loginButton.ForeColor = System.Drawing.Color.White;
            this._loginButton.Location = new System.Drawing.Point(299, 498);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(79, 54);
            this._loginButton.TabIndex = 5;
            this._loginButton.Text = "Autenticati";
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordTextBox.Location = new System.Drawing.Point(384, 437);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(143, 23);
            this._passwordTextBox.TabIndex = 4;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(296, 440);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(77, 17);
            this._passwordLabel.TabIndex = 3;
            this._passwordLabel.Text = "Password";
            // 
            // _usernameTextBox
            // 
            this._usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._usernameTextBox.Location = new System.Drawing.Point(384, 370);
            this._usernameTextBox.Name = "_usernameTextBox";
            this._usernameTextBox.Size = new System.Drawing.Size(143, 23);
            this._usernameTextBox.TabIndex = 2;
            // 
            // _userNameLabel
            // 
            this._userNameLabel.AutoSize = true;
            this._userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userNameLabel.Location = new System.Drawing.Point(296, 373);
            this._userNameLabel.Name = "_userNameLabel";
            this._userNameLabel.Size = new System.Drawing.Size(81, 17);
            this._userNameLabel.TabIndex = 1;
            this._userNameLabel.Text = "Username";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.circularPictureBox1.Image = global::GameReViews.Properties.Resources.ic_exit_to_app_white_48dp;
            this.circularPictureBox1.Location = new System.Drawing.Point(299, 85);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Padding = new System.Windows.Forms.Padding(35);
            this.circularPictureBox1.Size = new System.Drawing.Size(228, 236);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // _signinButton
            // 
            this._signinButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._signinButton.BackColor = System.Drawing.Color.Silver;
            this._signinButton.FlatAppearance.BorderSize = 0;
            this._signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._signinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._signinButton.ForeColor = System.Drawing.Color.White;
            this._signinButton.Location = new System.Drawing.Point(467, 498);
            this._signinButton.Name = "_signinButton";
            this._signinButton.Size = new System.Drawing.Size(77, 54);
            this._signinButton.TabIndex = 6;
            this._signinButton.Text = "Registrati";
            this._signinButton.UseVisualStyleBackColor = false;
            this._signinButton.Click += new System.EventHandler(this._signinButton_Click);
            // 
            // LogSignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._signinButton);
            this.Controls.Add(this._userInfoContainer_root);
            this.Name = "LogSignInView";
            this.Size = new System.Drawing.Size(883, 619);
            this._userInfoContainer_root.ResumeLayout(false);
            this._userInfoContainer.ResumeLayout(false);
            this._userInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _userInfoContainer_root;
        private System.Windows.Forms.Panel _userInfoContainer;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.TextBox _usernameTextBox;
        private System.Windows.Forms.Label _userNameLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Button _signinButton;
        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
