using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class CircularPictureBox : PictureBox
{
    public CircularPictureBox()
    {
        this.BackColor = Color.DarkGray;

        System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
        gp.AddEllipse(0, 0, this.Width - 3, this.Height - 3);
        Region rg = new Region(gp);
        this.Region = rg;
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            this.Region = new Region(gp);
        }
    }

    private void InitializeComponent()
    {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CircularPictureBox
            // 
            this.InitialImage = global::GameReViews.Properties.Resources.nonsensCapture;
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

    }
}