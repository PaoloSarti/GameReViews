namespace GameReViews.Presentation.View
{
    partial class AddVideogioco
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
            this._nomeView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._dataRilascioPicker = new System.Windows.Forms.DateTimePicker();
            this._genereComboBox = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._videogiocoImage = new CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._videogiocoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGGIUNGI VIDEOGIOCO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome videogioco";
            // 
            // _nomeView
            // 
            this._nomeView.Location = new System.Drawing.Point(401, 54);
            this._nomeView.Name = "_nomeView";
            this._nomeView.Size = new System.Drawing.Size(100, 20);
            this._nomeView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genere";
            // 
            // _dataRilascioPicker
            // 
            this._dataRilascioPicker.Location = new System.Drawing.Point(401, 89);
            this._dataRilascioPicker.Name = "_dataRilascioPicker";
            this._dataRilascioPicker.Size = new System.Drawing.Size(200, 20);
            this._dataRilascioPicker.TabIndex = 7;
            // 
            // _genereComboBox
            // 
            this._genereComboBox.FormattingEnabled = true;
            this._genereComboBox.Location = new System.Drawing.Point(401, 121);
            this._genereComboBox.Name = "_genereComboBox";
            this._genereComboBox.Size = new System.Drawing.Size(121, 21);
            this._genereComboBox.TabIndex = 8;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(276, 202);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 9;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(401, 202);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 10;
            this._cancelButton.Text = "CANCEL";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _videogiocoImage
            // 
            this._videogiocoImage.BackColor = System.Drawing.Color.DarkGray;
            this._videogiocoImage.InitialImage = global::GameReViews.Properties.Resources.nonsensCapture;
            this._videogiocoImage.Location = new System.Drawing.Point(12, 12);
            this._videogiocoImage.Name = "_videogiocoImage";
            this._videogiocoImage.Size = new System.Drawing.Size(177, 162);
            this._videogiocoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._videogiocoImage.TabIndex = 0;
            this._videogiocoImage.TabStop = false;
            this._videogiocoImage.Click += new System.EventHandler(this._videogiocoImage_Click);
            // 
            // AddVideogioco
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(846, 436);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._genereComboBox);
            this.Controls.Add(this._dataRilascioPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._nomeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._videogiocoImage);
            this.Name = "AddVideogioco";
            this.Text = "AddVideogioco";
            ((System.ComponentModel.ISupportInitialize)(this._videogiocoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox _videogiocoImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _nomeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _dataRilascioPicker;
        private System.Windows.Forms.ComboBox _genereComboBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}