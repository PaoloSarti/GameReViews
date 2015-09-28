namespace GameReViews.Presentation.View
{
    partial class AggiungiVideogioco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._videogiocoImage = new CircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._videogiocoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(873, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGGIUNGI VIDEOGIOCO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome videogioco";
            // 
            // _nomeView
            // 
            this._nomeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeView.Location = new System.Drawing.Point(243, 0);
            this._nomeView.Name = "_nomeView";
            this._nomeView.Size = new System.Drawing.Size(195, 26);
            this._nomeView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(-5, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genere";
            // 
            // _dataRilascioPicker
            // 
            this._dataRilascioPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataRilascioPicker.Location = new System.Drawing.Point(243, 59);
            this._dataRilascioPicker.Name = "_dataRilascioPicker";
            this._dataRilascioPicker.Size = new System.Drawing.Size(195, 20);
            this._dataRilascioPicker.TabIndex = 7;
            // 
            // _genereComboBox
            // 
            this._genereComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._genereComboBox.FormattingEnabled = true;
            this._genereComboBox.Location = new System.Drawing.Point(243, 112);
            this._genereComboBox.Name = "_genereComboBox";
            this._genereComboBox.Size = new System.Drawing.Size(195, 24);
            this._genereComboBox.TabIndex = 8;
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.Silver;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.FlatAppearance.BorderSize = 0;
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Location = new System.Drawing.Point(356, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(79, 54);
            this._okButton.TabIndex = 11;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = false;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.BackColor = System.Drawing.Color.Silver;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatAppearance.BorderSize = 0;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._cancelButton.ForeColor = System.Drawing.Color.White;
            this._cancelButton.Location = new System.Drawing.Point(271, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(79, 54);
            this._cancelButton.TabIndex = 12;
            this._cancelButton.Text = "CHIUDI";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this._videogiocoImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 93);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40);
            this.panel1.Size = new System.Drawing.Size(873, 346);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(335, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.panel2.Size = new System.Drawing.Size(498, 266);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this._nomeView);
            this.panel3.Controls.Add(this._genereComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this._dataRilascioPicker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 166);
            this.panel3.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._okButton);
            this.flowLayoutPanel1.Controls.Add(this._cancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 60);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // _videogiocoImage
            // 
            this._videogiocoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(253)))));
            this._videogiocoImage.Dock = System.Windows.Forms.DockStyle.Left;
            this._videogiocoImage.Image = global::GameReViews.Properties.Resources.ic_insert_photo_white_48dp;
            this._videogiocoImage.InitialImage = global::GameReViews.Properties.Resources.ic_add_circle_outline_white_48dp;
            this._videogiocoImage.Location = new System.Drawing.Point(40, 40);
            this._videogiocoImage.Name = "_videogiocoImage";
            this._videogiocoImage.Padding = new System.Windows.Forms.Padding(50);
            this._videogiocoImage.Size = new System.Drawing.Size(295, 266);
            this._videogiocoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._videogiocoImage.TabIndex = 0;
            this._videogiocoImage.TabStop = false;
            this._videogiocoImage.Click += new System.EventHandler(this._videogiocoImage_Click);
            this._videogiocoImage.MouseLeave += new System.EventHandler(this._videogiocoImage_MouseLeave);
            this._videogiocoImage.MouseHover += new System.EventHandler(this._videogiocoImage_MouseHover);
            // 
            // AddVideogioco
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(933, 444);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AddVideogioco";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Aggiungi videogioco";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._videogiocoImage)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}