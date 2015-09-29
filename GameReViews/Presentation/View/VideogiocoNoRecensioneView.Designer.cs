namespace GameReViews.View
{
    partial class VideogiocoNoRecensioneView
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
            this._aggiungiRecensione = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._recensioneNonDisponibile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._aggiungiRecensione);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this._recensioneNonDisponibile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(90, 0, 90, 0);
            this.panel1.Size = new System.Drawing.Size(1046, 628);
            this.panel1.TabIndex = 0;
            // 
            // _aggiungiRecensione
            // 
            this._aggiungiRecensione.BackColor = System.Drawing.Color.Silver;
            this._aggiungiRecensione.Dock = System.Windows.Forms.DockStyle.Top;
            this._aggiungiRecensione.FlatAppearance.BorderSize = 0;
            this._aggiungiRecensione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._aggiungiRecensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this._aggiungiRecensione.ForeColor = System.Drawing.Color.White;
            this._aggiungiRecensione.Location = new System.Drawing.Point(90, 221);
            this._aggiungiRecensione.Name = "_aggiungiRecensione";
            this._aggiungiRecensione.Size = new System.Drawing.Size(866, 90);
            this._aggiungiRecensione.TabIndex = 8;
            this._aggiungiRecensione.Text = "AGGIUNGI RECENSIONE";
            this._aggiungiRecensione.UseVisualStyleBackColor = false;
            this._aggiungiRecensione.Click += new System.EventHandler(this._aggiungiRecensione_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameReViews.Properties.Resources.bubble42;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // _recensioneNonDisponibile
            // 
            this._recensioneNonDisponibile.Dock = System.Windows.Forms.DockStyle.Top;
            this._recensioneNonDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._recensioneNonDisponibile.ForeColor = System.Drawing.Color.Firebrick;
            this._recensioneNonDisponibile.Location = new System.Drawing.Point(90, 0);
            this._recensioneNonDisponibile.Name = "_recensioneNonDisponibile";
            this._recensioneNonDisponibile.Size = new System.Drawing.Size(866, 221);
            this._recensioneNonDisponibile.TabIndex = 0;
            this._recensioneNonDisponibile.Text = "Recensione non disponibile";
            this._recensioneNonDisponibile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VideogiocoNoReviewDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoNoReviewDetailView";
            this.Size = new System.Drawing.Size(1046, 628);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _recensioneNonDisponibile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _aggiungiRecensione;
    }
}
