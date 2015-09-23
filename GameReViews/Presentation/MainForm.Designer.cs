namespace GameReViews
{
    partial class MainForm
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
            this._toolbar = new System.Windows.Forms.Panel();
            this._newSessionButton = new System.Windows.Forms.Button();
            this._utenteButton = new System.Windows.Forms.Button();
            this._videogiochiButton = new System.Windows.Forms.Button();
            this._recensioniButton = new System.Windows.Forms.Button();
            this._viewsContainer = new System.Windows.Forms.Panel();
            this._toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolbar
            // 
            this._toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this._toolbar.Controls.Add(this._newSessionButton);
            this._toolbar.Controls.Add(this._utenteButton);
            this._toolbar.Controls.Add(this._videogiochiButton);
            this._toolbar.Controls.Add(this._recensioniButton);
            this._toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this._toolbar.Location = new System.Drawing.Point(0, 0);
            this._toolbar.Name = "_toolbar";
            this._toolbar.Size = new System.Drawing.Size(889, 100);
            this._toolbar.TabIndex = 0;
            // 
            // _newSessionButton
            // 
            this._newSessionButton.BackColor = System.Drawing.Color.Transparent;
            this._newSessionButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._newSessionButton.FlatAppearance.BorderSize = 0;
            this._newSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._newSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._newSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._newSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            this._newSessionButton.Location = new System.Drawing.Point(99, 0);
            this._newSessionButton.Name = "_newSessionButton";
            this._newSessionButton.Size = new System.Drawing.Size(37, 100);
            this._newSessionButton.TabIndex = 3;
            this._newSessionButton.Text = "+";
            this._newSessionButton.UseVisualStyleBackColor = false;
            this._newSessionButton.Click += new System.EventHandler(this._newSessionButton_Click);
            // 
            // _utenteButton
            // 
            this._utenteButton.BackColor = System.Drawing.Color.Transparent;
            this._utenteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._utenteButton.FlatAppearance.BorderSize = 0;
            this._utenteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._utenteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._utenteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._utenteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._utenteButton.ForeColor = System.Drawing.Color.White;
            this._utenteButton.Location = new System.Drawing.Point(0, 0);
            this._utenteButton.Name = "_utenteButton";
            this._utenteButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._utenteButton.Size = new System.Drawing.Size(99, 100);
            this._utenteButton.TabIndex = 2;
            this._utenteButton.Text = "Utente";
            this._utenteButton.UseVisualStyleBackColor = false;
            // 
            // _videogiochiButton
            // 
            this._videogiochiButton.BackColor = System.Drawing.Color.Transparent;
            this._videogiochiButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._videogiochiButton.FlatAppearance.BorderSize = 0;
            this._videogiochiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._videogiochiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._videogiochiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._videogiochiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._videogiochiButton.ForeColor = System.Drawing.Color.White;
            this._videogiochiButton.Location = new System.Drawing.Point(561, 0);
            this._videogiochiButton.Name = "_videogiochiButton";
            this._videogiochiButton.Size = new System.Drawing.Size(173, 100);
            this._videogiochiButton.TabIndex = 1;
            this._videogiochiButton.Text = "Videogiochi";
            this._videogiochiButton.UseVisualStyleBackColor = false;
            this._videogiochiButton.Click += new System.EventHandler(this._videogiochiButton_Click);
            // 
            // _recensioniButton
            // 
            this._recensioniButton.BackColor = System.Drawing.Color.Transparent;
            this._recensioniButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._recensioniButton.FlatAppearance.BorderSize = 0;
            this._recensioniButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._recensioniButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this._recensioniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._recensioniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._recensioniButton.ForeColor = System.Drawing.Color.White;
            this._recensioniButton.Location = new System.Drawing.Point(734, 0);
            this._recensioniButton.Name = "_recensioniButton";
            this._recensioniButton.Size = new System.Drawing.Size(155, 100);
            this._recensioniButton.TabIndex = 0;
            this._recensioniButton.Text = "Recensioni";
            this._recensioniButton.UseVisualStyleBackColor = false;
            this._recensioniButton.Click += new System.EventHandler(this._recensioniButton_Click);
            // 
            // _viewsContainer
            // 
            this._viewsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._viewsContainer.Location = new System.Drawing.Point(0, 100);
            this._viewsContainer.Name = "_viewsContainer";
            this._viewsContainer.Size = new System.Drawing.Size(889, 551);
            this._viewsContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 651);
            this.Controls.Add(this._viewsContainer);
            this.Controls.Add(this._toolbar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this._toolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _toolbar;
        private System.Windows.Forms.Button _utenteButton;
        private System.Windows.Forms.Button _videogiochiButton;
        private System.Windows.Forms.Button _recensioniButton;
        private System.Windows.Forms.Panel _viewsContainer;
        private System.Windows.Forms.Button _newSessionButton;
    }
}

