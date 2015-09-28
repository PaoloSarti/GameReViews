namespace GameReViews.Presentation.View
{
    partial class AggiungiRecensione
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
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _recensioneText
            // 
            this._recensioneText.BackColor = System.Drawing.Color.White;
            this._recensioneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recensioneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this._recensioneText.ForeColor = System.Drawing.Color.DimGray;
            this._recensioneText.Location = new System.Drawing.Point(0, 6);
            this._recensioneText.Multiline = true;
            this._recensioneText.Name = "_recensioneText";
            this._recensioneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._recensioneText.Size = new System.Drawing.Size(949, 369);
            this._recensioneText.TabIndex = 3;
            this._recensioneText.Text = "Testo recensione";
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
            // AggiungiRecensione
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(949, 447);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._recensioneText);
            this.Name = "AggiungiRecensione";
            this.Text = "AggiungiRecensioneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _recensioneText;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}