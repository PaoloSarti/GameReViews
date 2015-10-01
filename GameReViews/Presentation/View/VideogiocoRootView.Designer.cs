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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._eliminaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._genereVideogiocoLabel = new System.Windows.Forms.Label();
            this._dataVideogiocoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._nomeVideogiocoLabel = new System.Windows.Forms.TextBox();
            this._immagineVideogioco = new CircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this._immagineVideogioco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30);
            this.panel2.Size = new System.Drawing.Size(828, 255);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this._nomeVideogiocoLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(235, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(563, 195);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._eliminaButton);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this._genereVideogiocoLabel);
            this.panel4.Controls.Add(this._dataVideogiocoLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 91);
            this.panel4.TabIndex = 6;
            // 
            // _eliminaButton
            // 
            this._eliminaButton.BackColor = System.Drawing.Color.Silver;
            this._eliminaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._eliminaButton.FlatAppearance.BorderSize = 0;
            this._eliminaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._eliminaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._eliminaButton.ForeColor = System.Drawing.Color.White;
            this._eliminaButton.Location = new System.Drawing.Point(476, 0);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(67, 91);
            this._eliminaButton.TabIndex = 8;
            this._eliminaButton.Text = "ELIMINA";
            this._eliminaButton.UseVisualStyleBackColor = false;
            this._eliminaButton.Click += new System.EventHandler(this._eliminaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genere";
            // 
            // _genereVideogiocoLabel
            // 
            this._genereVideogiocoLabel.AutoSize = true;
            this._genereVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._genereVideogiocoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._genereVideogiocoLabel.Location = new System.Drawing.Point(227, 0);
            this._genereVideogiocoLabel.Name = "_genereVideogiocoLabel";
            this._genereVideogiocoLabel.Size = new System.Drawing.Size(130, 39);
            this._genereVideogiocoLabel.TabIndex = 2;
            this._genereVideogiocoLabel.Text = "Genere";
            // 
            // _dataVideogiocoLabel
            // 
            this._dataVideogiocoLabel.AutoSize = true;
            this._dataVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataVideogiocoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._dataVideogiocoLabel.Location = new System.Drawing.Point(229, 63);
            this._dataVideogiocoLabel.Name = "_dataVideogiocoLabel";
            this._dataVideogiocoLabel.Size = new System.Drawing.Size(118, 25);
            this._dataVideogiocoLabel.TabIndex = 3;
            this._dataVideogiocoLabel.Text = "Data rilascio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data rilascio";
            // 
            // _nomeVideogiocoLabel
            // 
            this._nomeVideogiocoLabel.BackColor = System.Drawing.Color.White;
            this._nomeVideogiocoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._nomeVideogiocoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._nomeVideogiocoLabel.Enabled = false;
            this._nomeVideogiocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this._nomeVideogiocoLabel.Location = new System.Drawing.Point(10, 10);
            this._nomeVideogiocoLabel.Multiline = true;
            this._nomeVideogiocoLabel.Name = "_nomeVideogiocoLabel";
            this._nomeVideogiocoLabel.ReadOnly = true;
            this._nomeVideogiocoLabel.Size = new System.Drawing.Size(543, 84);
            this._nomeVideogiocoLabel.TabIndex = 0;
            this._nomeVideogiocoLabel.Text = "Nome videogioco";
            // 
            // _immagineVideogioco
            // 
            this._immagineVideogioco.BackColor = System.Drawing.Color.DarkGray;
            this._immagineVideogioco.Dock = System.Windows.Forms.DockStyle.Left;
            this._immagineVideogioco.InitialImage = null;
            this._immagineVideogioco.Location = new System.Drawing.Point(30, 30);
            this._immagineVideogioco.Name = "_immagineVideogioco";
            this._immagineVideogioco.Size = new System.Drawing.Size(205, 195);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._immagineVideogioco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _recensioneContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _dataVideogiocoLabel;
        private System.Windows.Forms.Label _genereVideogiocoLabel;
        private CircularPictureBox _immagineVideogioco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox _nomeVideogiocoLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button _eliminaButton;
    }
}
