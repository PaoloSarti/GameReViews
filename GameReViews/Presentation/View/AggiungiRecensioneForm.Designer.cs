namespace GameReViews.Presentation.View
{
    partial class AggiungiRecensioneForm
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
            this._recensioneText = new System.Windows.Forms.TextBox();
            this.customDataGridView1 = new GameReViews.CustomDataGridView();
            this._preferenzeControlPanel = new System.Windows.Forms.Panel();
            this._aggiungiPreferenza = new System.Windows.Forms.Button();
            this._aspettiValutatiLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._preferenzeControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _recensioneText
            // 
            this._recensioneText.BackColor = System.Drawing.Color.White;
            this._recensioneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recensioneText.Enabled = false;
            this._recensioneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this._recensioneText.ForeColor = System.Drawing.Color.DimGray;
            this._recensioneText.Location = new System.Drawing.Point(0, 6);
            this._recensioneText.Multiline = true;
            this._recensioneText.Name = "_recensioneText";
            this._recensioneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._recensioneText.Size = new System.Drawing.Size(949, 132);
            this._recensioneText.TabIndex = 3;
            this._recensioneText.Text = "Testo recensione";
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.Location = new System.Drawing.Point(0, 224);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.Size = new System.Drawing.Size(944, 130);
            this.customDataGridView1.TabIndex = 4;
            // 
            // _preferenzeControlPanel
            // 
            this._preferenzeControlPanel.Controls.Add(this._aggiungiPreferenza);
            this._preferenzeControlPanel.Controls.Add(this._aspettiValutatiLabel);
            this._preferenzeControlPanel.Location = new System.Drawing.Point(0, 144);
            this._preferenzeControlPanel.Name = "_preferenzeControlPanel";
            this._preferenzeControlPanel.Size = new System.Drawing.Size(937, 74);
            this._preferenzeControlPanel.TabIndex = 6;
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
            this._aggiungiPreferenza.Text = "Valuta Aspetto";
            this._aggiungiPreferenza.UseVisualStyleBackColor = false;
            this._aggiungiPreferenza.Click += new System.EventHandler(this._aggiungiPreferenza_Click);
            // 
            // _aspettiValutatiLabel
            // 
            this._aspettiValutatiLabel.AutoSize = true;
            this._aspettiValutatiLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._aspettiValutatiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aspettiValutatiLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._aspettiValutatiLabel.Location = new System.Drawing.Point(0, 0);
            this._aspettiValutatiLabel.Name = "_aspettiValutatiLabel";
            this._aspettiValutatiLabel.Padding = new System.Windows.Forms.Padding(90, 25, 50, 0);
            this._aspettiValutatiLabel.Size = new System.Drawing.Size(312, 50);
            this._aspettiValutatiLabel.TabIndex = 0;
            this._aspettiValutatiLabel.Text = "Aspetti Valutati";
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.Silver;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.FlatAppearance.BorderSize = 0;
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Location = new System.Drawing.Point(742, 381);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(79, 54);
            this._okButton.TabIndex = 13;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = false;
            // 
            // _cancelButton
            // 
            this._cancelButton.BackColor = System.Drawing.Color.Silver;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatAppearance.BorderSize = 0;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._cancelButton.ForeColor = System.Drawing.Color.White;
            this._cancelButton.Location = new System.Drawing.Point(858, 381);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(79, 54);
            this._cancelButton.TabIndex = 14;
            this._cancelButton.Text = "CANCEL";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // AggiungiRecensioneForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(949, 447);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._preferenzeControlPanel);
            this.Controls.Add(this.customDataGridView1);
            this.Controls.Add(this._recensioneText);
            this.Name = "AggiungiRecensioneForm";
            this.Text = "AggiungiRecensioneForm";
            this._preferenzeControlPanel.ResumeLayout(false);
            this._preferenzeControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _recensioneText;
        private CustomDataGridView customDataGridView1;
        private System.Windows.Forms.Panel _preferenzeControlPanel;
        private System.Windows.Forms.Button _aggiungiPreferenza;
        private System.Windows.Forms.Label _aspettiValutatiLabel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}