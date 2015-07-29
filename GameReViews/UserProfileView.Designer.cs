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
            this._userName = new System.Windows.Forms.Label();
            this._userInfoContainer = new System.Windows.Forms.Panel();
            this.circularPictureBox1 = new CircularPictureBox();
            this._userInfoContainer_root.SuspendLayout();
            this._userInfoContainer.SuspendLayout();
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
            this._userInfoContainer_root.Paint += new System.Windows.Forms.PaintEventHandler(this._userInfoContainer_root_Paint);
            // 
            // _userName
            // 
            this._userName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._userName.AutoSize = true;
            this._userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userName.Location = new System.Drawing.Point(382, 55);
            this._userName.Name = "_userName";
            this._userName.Size = new System.Drawing.Size(336, 39);
            this._userName.TabIndex = 1;
            this._userName.Text = "Smoky ChickenFish";
            // 
            // _userInfoContainer
            // 
            this._userInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._userInfoContainer.BackColor = System.Drawing.Color.White;
            this._userInfoContainer.Controls.Add(this.circularPictureBox1);
            this._userInfoContainer.Controls.Add(this._userName);
            this._userInfoContainer.Location = new System.Drawing.Point(17, 0);
            this._userInfoContainer.Name = "_userInfoContainer";
            this._userInfoContainer.Size = new System.Drawing.Size(849, 619);
            this._userInfoContainer.TabIndex = 3;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circularPictureBox1.BackColor = System.Drawing.Color.Purple;
            this.circularPictureBox1.Image = global::GameReViews.Properties.Resources.nonsensCapture;
            this.circularPictureBox1.Location = new System.Drawing.Point(102, 55);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(223, 204);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
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
            this._userInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _userInfoContainer_root;
        private System.Windows.Forms.Label _userName;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Panel _userInfoContainer;
    }
}
