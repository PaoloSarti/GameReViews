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
            this._recensioneContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._dataVideogiocoLabel = new System.Windows.Forms.Label();
            this._genereVideogiocoLabel = new System.Windows.Forms.Label();
            this._nomeVideogiocoLabel = new System.Windows.Forms.Label();
            this._immagineVideogioco = new CircularPictureBox();
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
            this.panel1.Location = new System.Drawing.Point(90, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 645);
            this.panel1.TabIndex = 0;
            // 
            // _recensioneContainer
            // 
            this._recensioneContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recensioneContainer.Location = new System.Drawing.Point(0, 255);
            this._recensioneContainer.Name = "_recensioneContainer";
            this._recensioneContainer.Size = new System.Drawing.Size(828, 390);
            this._recensioneContainer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._dataVideogiocoLabel);
            this.panel2.Controls.Add(this._genereVideogiocoLabel);
            this.panel2.Controls.Add(this._nomeVideogiocoLabel);
            this.panel2.Controls.Add(this._immagineVideogioco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 255);
            this.panel2.TabIndex = 0;
            // 
            // _dataVideogiocoLabel
            // 
            this._dataVideogiocoLabel.AutoSize = true;
            this._dataVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataVideogiocoLabel.Location = new System.Drawing.Point(338, 166);
            this._dataVideogiocoLabel.Name = "_dataVideogiocoLabel";
            this._dataVideogiocoLabel.Size = new System.Drawing.Size(88, 15);
            this._dataVideogiocoLabel.TabIndex = 3;
            this._dataVideogiocoLabel.Text = "Data rilascio";
            // 
            // _genereVideogiocoLabel
            // 
            this._genereVideogiocoLabel.AutoSize = true;
            this._genereVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._genereVideogiocoLabel.Location = new System.Drawing.Point(338, 90);
            this._genereVideogiocoLabel.Name = "_genereVideogiocoLabel";
            this._genereVideogiocoLabel.Size = new System.Drawing.Size(54, 15);
            this._genereVideogiocoLabel.TabIndex = 2;
            this._genereVideogiocoLabel.Text = "Genere";
            // 
            // _nomeVideogiocoLabel
            // 
            this._nomeVideogiocoLabel.AutoSize = true;
            this._nomeVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeVideogiocoLabel.Location = new System.Drawing.Point(335, 37);
            this._nomeVideogiocoLabel.Name = "_nomeVideogiocoLabel";
            this._nomeVideogiocoLabel.Size = new System.Drawing.Size(178, 25);
            this._nomeVideogiocoLabel.TabIndex = 1;
            this._nomeVideogiocoLabel.Text = "Nome videogioco";
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
            // VideogiocoRootView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoRootView";
            this.Size = new System.Drawing.Size(1023, 645);
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
        private System.Windows.Forms.Label _dataVideogiocoLabel;
        private System.Windows.Forms.Label _genereVideogiocoLabel;
        private System.Windows.Forms.Label _nomeVideogiocoLabel;
        private CircularPictureBox _immagineVideogioco;
    }
}
