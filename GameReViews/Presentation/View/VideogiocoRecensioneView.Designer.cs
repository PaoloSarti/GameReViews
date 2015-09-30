namespace GameReViews.View
{
    partial class VideogiocoRecensioneView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this._recensoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._valutaAspettoButton = new System.Windows.Forms.Button();
            this._recensioneText = new System.Windows.Forms.TextBox();
            this._valutazione = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._customDataGridView = new GameReViews.CustomDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this._recensoreLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this._valutaAspettoButton);
            this.panel2.Controls.Add(this._recensioneText);
            this.panel2.Controls.Add(this._valutazione);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(35, 30, 30, 30);
            this.panel2.Size = new System.Drawing.Size(1027, 232);
            this.panel2.TabIndex = 0;
            // 
            // _recensoreLabel
            // 
            this._recensoreLabel.AutoSize = true;
            this._recensoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this._recensoreLabel.ForeColor = System.Drawing.Color.DimGray;
            this._recensoreLabel.Location = new System.Drawing.Point(464, 177);
            this._recensoreLabel.Name = "_recensoreLabel";
            this._recensoreLabel.Size = new System.Drawing.Size(64, 25);
            this._recensoreLabel.TabIndex = 5;
            this._recensoreLabel.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(343, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recensore";
            // 
            // _valutaAspettoButton
            // 
            this._valutaAspettoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._valutaAspettoButton.BackColor = System.Drawing.Color.Silver;
            this._valutaAspettoButton.FlatAppearance.BorderSize = 0;
            this._valutaAspettoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._valutaAspettoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._valutaAspettoButton.ForeColor = System.Drawing.Color.White;
            this._valutaAspettoButton.Location = new System.Drawing.Point(835, 164);
            this._valutaAspettoButton.Name = "_valutaAspettoButton";
            this._valutaAspettoButton.Size = new System.Drawing.Size(162, 57);
            this._valutaAspettoButton.TabIndex = 3;
            this._valutaAspettoButton.Text = "Valuta Aspetto";
            this._valutaAspettoButton.UseVisualStyleBackColor = false;
            this._valutaAspettoButton.Click += new System.EventHandler(this._valutaAspettoButton_Click);
            // 
            // _recensioneText
            // 
            this._recensioneText.BackColor = System.Drawing.Color.White;
            this._recensioneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recensioneText.Dock = System.Windows.Forms.DockStyle.Top;
            this._recensioneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this._recensioneText.ForeColor = System.Drawing.Color.DimGray;
            this._recensioneText.Location = new System.Drawing.Point(35, 30);
            this._recensioneText.Multiline = true;
            this._recensioneText.Name = "_recensioneText";
            this._recensioneText.ReadOnly = true;
            this._recensioneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._recensioneText.Size = new System.Drawing.Size(962, 131);
            this._recensioneText.TabIndex = 2;
            this._recensioneText.Text = "Testo recensione";
            // 
            // _valutazione
            // 
            this._valutazione.AutoSize = true;
            this._valutazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this._valutazione.ForeColor = System.Drawing.Color.DimGray;
            this._valutazione.Location = new System.Drawing.Point(187, 177);
            this._valutazione.Name = "_valutazione";
            this._valutazione.Size = new System.Drawing.Size(64, 25);
            this._valutazione.TabIndex = 1;
            this._valutazione.Text = "value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valutazione";
            // 
            // _customDataGridView
            // 
            this._customDataGridView.AutoSize = true;
            this._customDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customDataGridView.Location = new System.Drawing.Point(0, 232);
            this._customDataGridView.Name = "_customDataGridView";
            this._customDataGridView.Size = new System.Drawing.Size(1027, 400);
            this._customDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._customDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 632);
            this.panel1.TabIndex = 2;
            // 
            // VideogiocoYesReviewDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideogiocoYesReviewDetailView";
            this.Size = new System.Drawing.Size(1027, 632);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _recensoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _valutaAspettoButton;
        private System.Windows.Forms.TextBox _recensioneText;
        private System.Windows.Forms.Label _valutazione;
        private System.Windows.Forms.Label label1;
        private CustomDataGridView _customDataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}
