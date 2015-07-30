namespace GameReViews
{
    partial class VideogiochiView
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
            this._videogiochiContainer = new System.Windows.Forms.Panel();
            this._aggiungiVideogiocoButton = new System.Windows.Forms.Button();
            this._videogiochiList = new GameReViews.CustomDataGridView();
            this._videogiochiContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _videogiochiContainer
            // 
            this._videogiochiContainer.Controls.Add(this._videogiochiList);
            this._videogiochiContainer.Controls.Add(this._aggiungiVideogiocoButton);
            this._videogiochiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._videogiochiContainer.Location = new System.Drawing.Point(0, 0);
            this._videogiochiContainer.Name = "_videogiochiContainer";
            this._videogiochiContainer.Size = new System.Drawing.Size(917, 623);
            this._videogiochiContainer.TabIndex = 0;
            // 
            // _aggiungiVideogiocoButton
            // 
            this._aggiungiVideogiocoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this._aggiungiVideogiocoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._aggiungiVideogiocoButton.FlatAppearance.BorderSize = 0;
            this._aggiungiVideogiocoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this._aggiungiVideogiocoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this._aggiungiVideogiocoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._aggiungiVideogiocoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aggiungiVideogiocoButton.ForeColor = System.Drawing.Color.White;
            this._aggiungiVideogiocoButton.Location = new System.Drawing.Point(0, 0);
            this._aggiungiVideogiocoButton.Name = "_aggiungiVideogiocoButton";
            this._aggiungiVideogiocoButton.Size = new System.Drawing.Size(917, 92);
            this._aggiungiVideogiocoButton.TabIndex = 0;
            this._aggiungiVideogiocoButton.Text = "Aggiungi Videogioco";
            this._aggiungiVideogiocoButton.UseVisualStyleBackColor = false;
            // 
            // _videogiochiList
            // 
            this._videogiochiList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._videogiochiList.Location = new System.Drawing.Point(0, 92);
            this._videogiochiList.Name = "_videogiochiList";
            this._videogiochiList.Size = new System.Drawing.Size(917, 531);
            this._videogiochiList.TabIndex = 1;
            // 
            // VideogiochiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._videogiochiContainer);
            this.Name = "VideogiochiView";
            this.Size = new System.Drawing.Size(917, 623);
            this._videogiochiContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _videogiochiContainer;
        private CustomDataGridView _videogiochiList;
        private System.Windows.Forms.Button _aggiungiVideogiocoButton;
    }
}
