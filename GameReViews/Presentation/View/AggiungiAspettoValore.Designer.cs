namespace GameReViews.Presentation.View
{
    partial class AggiungiAspettoValore
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
            this._valutazione = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._aspettiCombo = new System.Windows.Forms.ComboBox();
            this._valutazioneLabel = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._valutazione)).BeginInit();
            this.SuspendLayout();
            // 
            // _valutazione
            // 
            this._valutazione.Location = new System.Drawing.Point(221, 48);
            this._valutazione.Name = "_valutazione";
            this._valutazione.Size = new System.Drawing.Size(120, 20);
            this._valutazione.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aspetto";
            // 
            // _aspettiCombo
            // 
            this._aspettiCombo.FormattingEnabled = true;
            this._aspettiCombo.Location = new System.Drawing.Point(51, 47);
            this._aspettiCombo.Name = "_aspettiCombo";
            this._aspettiCombo.Size = new System.Drawing.Size(121, 21);
            this._aspettiCombo.TabIndex = 2;
            // 
            // _valutazioneLabel
            // 
            this._valutazioneLabel.AutoSize = true;
            this._valutazioneLabel.Location = new System.Drawing.Point(221, 13);
            this._valutazioneLabel.Name = "_valutazioneLabel";
            this._valutazioneLabel.Size = new System.Drawing.Size(62, 13);
            this._valutazioneLabel.TabIndex = 3;
            this._valutazioneLabel.Text = "Valutazione";
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(266, 116);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 12;
            this._cancelButton.Text = "CANCEL";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(157, 116);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 11;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // AggiungiAspettoValore
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(681, 523);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._valutazioneLabel);
            this.Controls.Add(this._aspettiCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._valutazione);
            this.Name = "AggiungiAspettoValore";
            this.Text = "AggiungiAspettoValore";
            ((System.ComponentModel.ISupportInitialize)(this._valutazione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _valutazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _aspettiCombo;
        private System.Windows.Forms.Label _valutazioneLabel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
    }
}