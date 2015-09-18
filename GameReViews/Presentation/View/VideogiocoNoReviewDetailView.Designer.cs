namespace GameReViews.View
{
    partial class VideogiocoNoReviewDetailView
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
            this._recensioneNonDisponibile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._aggiungiRecensione);
            this.panel1.Controls.Add(this._recensioneNonDisponibile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 628);
            this.panel1.TabIndex = 0;
            // 
            // _aggiungiRecensione
            // 
            this._aggiungiRecensione.Location = new System.Drawing.Point(114, 123);
            this._aggiungiRecensione.Name = "_aggiungiRecensione";
            this._aggiungiRecensione.Size = new System.Drawing.Size(180, 38);
            this._aggiungiRecensione.TabIndex = 1;
            this._aggiungiRecensione.Text = "Aggiungi recensione";
            this._aggiungiRecensione.UseVisualStyleBackColor = true;
            this._aggiungiRecensione.Click += new System.EventHandler(this._aggiungiRecensione_Click);
            // 
            // _recensioneNonDisponibile
            // 
            this._recensioneNonDisponibile.AutoSize = true;
            this._recensioneNonDisponibile.Location = new System.Drawing.Point(111, 59);
            this._recensioneNonDisponibile.Name = "_recensioneNonDisponibile";
            this._recensioneNonDisponibile.Size = new System.Drawing.Size(137, 13);
            this._recensioneNonDisponibile.TabIndex = 0;
            this._recensioneNonDisponibile.Text = "Recensione non disponibile";
            // 
            // VideogiocoNoReviewDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoNoReviewDetailView";
            this.Size = new System.Drawing.Size(1046, 628);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _aggiungiRecensione;
        private System.Windows.Forms.Label _recensioneNonDisponibile;
    }
}
