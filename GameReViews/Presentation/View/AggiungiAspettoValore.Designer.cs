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
            this._aspettiCombo = new System.Windows.Forms.ComboBox();
            this._titoloLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._descrizioneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._valutazioneLabel = new System.Windows.Forms.Label();
            this._aspettoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._valutazione)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _valutazione
            // 
            this._valutazione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._valutazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._valutazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._valutazione.Location = new System.Drawing.Point(302, 302);
            this._valutazione.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._valutazione.Name = "_valutazione";
            this._valutazione.ReadOnly = true;
            this._valutazione.Size = new System.Drawing.Size(254, 23);
            this._valutazione.TabIndex = 0;
            // 
            // _aspettiCombo
            // 
            this._aspettiCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._aspettiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._aspettiCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aspettiCombo.FormattingEnabled = true;
            this._aspettiCombo.Location = new System.Drawing.Point(302, 119);
            this._aspettiCombo.Name = "_aspettiCombo";
            this._aspettiCombo.Size = new System.Drawing.Size(254, 24);
            this._aspettiCombo.TabIndex = 2;
            this._aspettiCombo.SelectedIndexChanged += new System.EventHandler(this._aspettiCombo_SelectedIndexChanged);
            // 
            // _titoloLabel
            // 
            this._titoloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this._titoloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._titoloLabel.Location = new System.Drawing.Point(0, 0);
            this._titoloLabel.Name = "_titoloLabel";
            this._titoloLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._titoloLabel.Size = new System.Drawing.Size(559, 69);
            this._titoloLabel.TabIndex = 1;
            this._titoloLabel.Text = "AGGIUNGI PREFERENZA";
            this._titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this._descrizioneTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this._valutazione);
            this.panel2.Controls.Add(this._valutazioneLabel);
            this.panel2.Controls.Add(this._aspettiCombo);
            this.panel2.Controls.Add(this._aspettoLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel2.Size = new System.Drawing.Size(559, 427);
            this.panel2.TabIndex = 2;
            // 
            // _descrizioneTextBox
            // 
            this._descrizioneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._descrizioneTextBox.Location = new System.Drawing.Point(302, 169);
            this._descrizioneTextBox.Margin = new System.Windows.Forms.Padding(0);
            this._descrizioneTextBox.Multiline = true;
            this._descrizioneTextBox.Name = "_descrizioneTextBox";
            this._descrizioneTextBox.ReadOnly = true;
            this._descrizioneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._descrizioneTextBox.Size = new System.Drawing.Size(257, 96);
            this._descrizioneTextBox.TabIndex = 7;
            this._descrizioneTextBox.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrizione";
            // 
            // _valutazioneLabel
            // 
            this._valutazioneLabel.AutoSize = true;
            this._valutazioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this._valutazioneLabel.ForeColor = System.Drawing.Color.DimGray;
            this._valutazioneLabel.Location = new System.Drawing.Point(3, 297);
            this._valutazioneLabel.Name = "_valutazioneLabel";
            this._valutazioneLabel.Size = new System.Drawing.Size(137, 26);
            this._valutazioneLabel.TabIndex = 5;
            this._valutazioneLabel.Text = "Valutazione";
            // 
            // _aspettoLabel
            // 
            this._aspettoLabel.AutoSize = true;
            this._aspettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this._aspettoLabel.ForeColor = System.Drawing.Color.DimGray;
            this._aspettoLabel.Location = new System.Drawing.Point(3, 115);
            this._aspettoLabel.Name = "_aspettoLabel";
            this._aspettoLabel.Size = new System.Drawing.Size(75, 26);
            this._aspettoLabel.TabIndex = 4;
            this._aspettoLabel.Text = "Nome";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._okButton);
            this.flowLayoutPanel1.Controls.Add(this._cancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 377);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 80);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.Color.Silver;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.FlatAppearance.BorderSize = 0;
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this._okButton.ForeColor = System.Drawing.Color.White;
            this._okButton.Location = new System.Drawing.Point(417, 13);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(139, 54);
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
            this._cancelButton.Location = new System.Drawing.Point(302, 13);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(109, 54);
            this._cancelButton.TabIndex = 14;
            this._cancelButton.Text = "CHIUDI";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._titoloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 69);
            this.panel1.TabIndex = 1;
            // 
            // AggiungiAspettoValore
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(619, 467);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "AggiungiAspettoValore";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Aggiungi";
            ((System.ComponentModel.ISupportInitialize)(this._valutazione)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _valutazione;
        private System.Windows.Forms.ComboBox _aspettiCombo;
        private System.Windows.Forms.Label _titoloLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _aspettoLabel;
        private System.Windows.Forms.Label _valutazioneLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _descrizioneTextBox;
    }
}