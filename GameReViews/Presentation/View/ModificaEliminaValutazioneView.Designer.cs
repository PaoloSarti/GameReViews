namespace GameReViews.Presentation.View
{
    partial class ModificaEliminaValutazioneView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._nomeText = new System.Windows.Forms.TextBox();
            this._descrizioneText = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._valutazioneNumeric = new System.Windows.Forms.NumericUpDown();
            this._eliminaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._valutazioneNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrizione";
            // 
            // _nomeText
            // 
            this._nomeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._nomeText.Location = new System.Drawing.Point(87, 13);
            this._nomeText.Name = "_nomeText";
            this._nomeText.ReadOnly = true;
            this._nomeText.Size = new System.Drawing.Size(184, 13);
            this._nomeText.TabIndex = 2;
            // 
            // _descrizioneText
            // 
            this._descrizioneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._descrizioneText.Location = new System.Drawing.Point(87, 52);
            this._descrizioneText.Multiline = true;
            this._descrizioneText.Name = "_descrizioneText";
            this._descrizioneText.ReadOnly = true;
            this._descrizioneText.Size = new System.Drawing.Size(184, 63);
            this._descrizioneText.TabIndex = 3;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(310, 106);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 4;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(391, 106);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 5;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valutazione";
            // 
            // _valutazioneNumeric
            // 
            this._valutazioneNumeric.Location = new System.Drawing.Point(347, 13);
            this._valutazioneNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._valutazioneNumeric.Name = "_valutazioneNumeric";
            this._valutazioneNumeric.Size = new System.Drawing.Size(120, 20);
            this._valutazioneNumeric.TabIndex = 7;
            // 
            // _eliminaButton
            // 
            this._eliminaButton.Location = new System.Drawing.Point(347, 52);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(119, 23);
            this._eliminaButton.TabIndex = 8;
            this._eliminaButton.Text = "Elimina";
            this._eliminaButton.UseVisualStyleBackColor = true;
            this._eliminaButton.Click += new System.EventHandler(this._eliminaButton_Click);
            // 
            // ModificaEliminaValutazioneView
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(478, 141);
            this.Controls.Add(this._eliminaButton);
            this.Controls.Add(this._valutazioneNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._descrizioneText);
            this.Controls.Add(this._nomeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ModificaEliminaValutazioneView";
            this.Text = "ModificaEliminaValutazioneView";
            ((System.ComponentModel.ISupportInitialize)(this._valutazioneNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _nomeText;
        private System.Windows.Forms.TextBox _descrizioneText;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _valutazioneNumeric;
        private System.Windows.Forms.Button _eliminaButton;
    }
}