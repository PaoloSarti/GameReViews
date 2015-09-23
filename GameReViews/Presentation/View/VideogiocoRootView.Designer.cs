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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
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
            this._dataVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataVideogiocoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._dataVideogiocoLabel.Location = new System.Drawing.Point(488, 203);
            this._dataVideogiocoLabel.Name = "_dataVideogiocoLabel";
            this._dataVideogiocoLabel.Size = new System.Drawing.Size(118, 25);
            this._dataVideogiocoLabel.TabIndex = 3;
            this._dataVideogiocoLabel.Text = "Data rilascio";
            // 
            // _genereVideogiocoLabel
            // 
            this._genereVideogiocoLabel.AutoSize = true;
            this._genereVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._genereVideogiocoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._genereVideogiocoLabel.Location = new System.Drawing.Point(486, 130);
            this._genereVideogiocoLabel.Name = "_genereVideogiocoLabel";
            this._genereVideogiocoLabel.Size = new System.Drawing.Size(130, 39);
            this._genereVideogiocoLabel.TabIndex = 2;
            this._genereVideogiocoLabel.Text = "Genere";
            // 
            // _nomeVideogiocoLabel
            // 
            this._nomeVideogiocoLabel.AutoSize = true;
            this._nomeVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeVideogiocoLabel.Location = new System.Drawing.Point(298, 37);
            this._nomeVideogiocoLabel.Name = "_nomeVideogiocoLabel";
            this._nomeVideogiocoLabel.Size = new System.Drawing.Size(460, 63);
            this._nomeVideogiocoLabel.TabIndex = 1;
            this._nomeVideogiocoLabel.Text = "Nome videogioco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data rilascio";
            // 
            // _immagineVideogioco
            // 
            this._immagineVideogioco.BackColor = System.Drawing.Color.DarkGray;
            this._immagineVideogioco.InitialImage = null;
            this._immagineVideogioco.Location = new System.Drawing.Point(44, 37);
            this._immagineVideogioco.Name = "_immagineVideogioco";
            this._immagineVideogioco.Size = new System.Drawing.Size(205, 191);
            this._immagineVideogioco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
