namespace GameReViews.View
{
    partial class VideogiocoRootView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._immagineVideogioco = new CircularPictureBox();
            this._nomeVideogioco = new System.Windows.Forms.Label();
            this._genereVideogioco = new System.Windows.Forms.Label();
            this._dataVideogioco = new System.Windows.Forms.Label();
            this._recensioneContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._immagineVideogioco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._recensioneContainer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 645);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._dataVideogioco);
            this.panel2.Controls.Add(this._genereVideogioco);
            this.panel2.Controls.Add(this._nomeVideogioco);
            this.panel2.Controls.Add(this._immagineVideogioco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 255);
            this.panel2.TabIndex = 0;
            // 
            // _immagineVideogioco
            // 
            this._immagineVideogioco.BackColor = System.Drawing.Color.DarkGray;
            this._immagineVideogioco.Location = new System.Drawing.Point(56, 37);
            this._immagineVideogioco.Name = "_immagineVideogioco";
            this._immagineVideogioco.Size = new System.Drawing.Size(167, 160);
            this._immagineVideogioco.TabIndex = 0;
            this._immagineVideogioco.TabStop = false;
            // 
            // _nomeVideogioco
            // 
            this._nomeVideogioco.AutoSize = true;
            this._nomeVideogioco.Location = new System.Drawing.Point(335, 37);
            this._nomeVideogioco.Name = "_nomeVideogioco";
            this._nomeVideogioco.Size = new System.Drawing.Size(90, 13);
            this._nomeVideogioco.TabIndex = 1;
            this._nomeVideogioco.Text = "Nome videogioco";
            // 
            // _genereVideogioco
            // 
            this._genereVideogioco.AutoSize = true;
            this._genereVideogioco.Location = new System.Drawing.Point(338, 90);
            this._genereVideogioco.Name = "_genereVideogioco";
            this._genereVideogioco.Size = new System.Drawing.Size(42, 13);
            this._genereVideogioco.TabIndex = 2;
            this._genereVideogioco.Text = "Genere";
            // 
            // _dataVideogioco
            // 
            this._dataVideogioco.AutoSize = true;
            this._dataVideogioco.Location = new System.Drawing.Point(338, 166);
            this._dataVideogioco.Name = "_dataVideogioco";
            this._dataVideogioco.Size = new System.Drawing.Size(65, 13);
            this._dataVideogioco.TabIndex = 3;
            this._dataVideogioco.Text = "Data rilascio";
            // 
            // _recensioneContainer
            // 
            this._recensioneContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recensioneContainer.Location = new System.Drawing.Point(0, 255);
            this._recensioneContainer.Name = "_recensioneContainer";
            this._recensioneContainer.Size = new System.Drawing.Size(932, 390);
            this._recensioneContainer.TabIndex = 1;
            // 
            // VideogiocoRootView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoRootView";
            this.Size = new System.Drawing.Size(1081, 645);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._immagineVideogioco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _recensioneContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _dataVideogioco;
        private System.Windows.Forms.Label _genereVideogioco;
        private System.Windows.Forms.Label _nomeVideogioco;
        private CircularPictureBox _immagineVideogioco;
    }
}
