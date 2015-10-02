namespace GameReViews.Presentation.View
{
    partial class ModificaEliminaValutazione
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._titoloLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._modificaPanel = new System.Windows.Forms.Panel();
            this._valutazioneNumeric = new System.Windows.Forms.NumericUpDown();
            this._valutazioneLabel = new System.Windows.Forms.Label();
            this._eliminaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._descrizioneText = new System.Windows.Forms.TextBox();
            this._nomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._aspettoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this._modificaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._valutazioneNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._okButton);
            this.flowLayoutPanel1.Controls.Add(this._cancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 413);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 60);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.Silver;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.FlatAppearance.BorderSize = 0;
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Location = new System.Drawing.Point(415, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(139, 54);
            this._okButton.TabIndex = 15;
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
            this._cancelButton.Location = new System.Drawing.Point(300, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(109, 54);
            this._cancelButton.TabIndex = 16;
            this._cancelButton.Text = "CHIUDI";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // _titoloLabel
            // 
            this._titoloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this._titoloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._titoloLabel.Location = new System.Drawing.Point(30, 30);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._titoloLabel.Size = new System.Drawing.Size(557, 69);
            this._titoloLabel.TabIndex = 10;
            this._titoloLabel.Text = "MODIFICA PREFERENZA";
            this._titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._modificaPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 314);
            this.panel1.TabIndex = 11;
            // 
            // _modificaPanel
            // 
            this._modificaPanel.Controls.Add(this._valutazioneNumeric);
            this._modificaPanel.Controls.Add(this._valutazioneLabel);
            this._modificaPanel.Controls.Add(this._eliminaButton);
            this._modificaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._modificaPanel.Location = new System.Drawing.Point(0, 174);
            this._modificaPanel.Name = "_modificaPanel";
            this._modificaPanel.Size = new System.Drawing.Size(557, 140);
            this._modificaPanel.TabIndex = 10;
            // 
            // _valutazioneNumeric
            // 
            this._valutazioneNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._valutazioneNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._valutazioneNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._valutazioneNumeric.Location = new System.Drawing.Point(300, 24);
            this._valutazioneNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._valutazioneNumeric.Name = "_valutazioneNumeric";
            this._valutazioneNumeric.ReadOnly = true;
            this._valutazioneNumeric.Size = new System.Drawing.Size(254, 23);
            this._valutazioneNumeric.TabIndex = 18;
            // 
            // _valutazioneLabel
            // 
            this._valutazioneLabel.AutoSize = true;
            this._valutazioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this._valutazioneLabel.ForeColor = System.Drawing.Color.DimGray;
            this._valutazioneLabel.Location = new System.Drawing.Point(4, 21);
            this._valutazioneLabel.Name = "_valutazioneLabel";
            this._valutazioneLabel.Size = new System.Drawing.Size(137, 26);
            this._valutazioneLabel.TabIndex = 17;
            this._valutazioneLabel.Text = "Valutazione";
            // 
            // _eliminaButton
            // 
            this._eliminaButton.BackColor = System.Drawing.Color.Silver;
            this._eliminaButton.FlatAppearance.BorderSize = 0;
            this._eliminaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._eliminaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._eliminaButton.ForeColor = System.Drawing.Color.White;
            this._eliminaButton.Location = new System.Drawing.Point(415, 66);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(139, 54);
            this._eliminaButton.TabIndex = 16;
            this._eliminaButton.Text = "RIMUOVI";
            this._eliminaButton.UseVisualStyleBackColor = false;
            this._eliminaButton.Click += new System.EventHandler(this._eliminaButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._descrizioneText);
            this.panel2.Controls.Add(this._nomeText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._aspettoLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 174);
            this.panel2.TabIndex = 9;
            // 
            // _descrizioneText
            // 
            this._descrizioneText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._descrizioneText.Location = new System.Drawing.Point(297, 70);
            this._descrizioneText.Margin = new System.Windows.Forms.Padding(0);
            this._descrizioneText.Multiline = true;
            this._descrizioneText.Name = "_descrizioneText";
            this._descrizioneText.ReadOnly = true;
            this._descrizioneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._descrizioneText.Size = new System.Drawing.Size(257, 90);
            this._descrizioneText.TabIndex = 9;
            this._descrizioneText.Text = "text";
            // 
            // _nomeText
            // 
            this._nomeText.AutoSize = true;
            this._nomeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._nomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this._nomeText.ForeColor = System.Drawing.Color.DimGray;
            this._nomeText.Location = new System.Drawing.Point(425, 23);
            this._nomeText.Name = "_nomeText";
            this._nomeText.Size = new System.Drawing.Size(129, 26);
            this._nomeText.TabIndex = 8;
            this._nomeText.Text = "nameLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrizione";
            // 
            // _aspettoLabel
            // 
            this._aspettoLabel.AutoSize = true;
            this._aspettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this._aspettoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._aspettoLabel.Location = new System.Drawing.Point(4, 23);
            this._aspettoLabel.Name = "_aspettoLabel";
            this._aspettoLabel.Size = new System.Drawing.Size(75, 26);
            this._aspettoLabel.TabIndex = 5;
            this._aspettoLabel.Text = "Nome";
            // 
            // ModificaEliminaValutazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 483);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._titoloLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ModificaEliminaValutazione";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.ShowInTaskbar = false;
            this.Text = "ModificaEliminaValutazioneView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this._modificaPanel.ResumeLayout(false);
            this._modificaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._valutazioneNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel _modificaPanel;
        private System.Windows.Forms.Button _eliminaButton;
        private System.Windows.Forms.Label _aspettoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _nomeText;
        private System.Windows.Forms.TextBox _descrizioneText;
        private System.Windows.Forms.Label _valutazioneLabel;
        private System.Windows.Forms.NumericUpDown _valutazioneNumeric;
    }
}