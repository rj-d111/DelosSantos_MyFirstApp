using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.CustomControls
{
    public class TransparentBackgroundTextBox : TextBox
    {
    
        // Declare the properties for the background gradient colors
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        public LinearGradientMode GradientDirection { get; set; }
        public TransparentBackgroundTextBox() {
            //Transparency Support
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;

            //My Setttings
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Font font = new Font("Segoe UI", 14.0f);
            this.Font = font;
            //Gradient Support

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            SolidBrush sb = new SolidBrush(this.ForeColor);

            LinearGradientBrush lb = new LinearGradientBrush(this.ClientRectangle, ColorTop, ColorBottom, GradientDirection);
            e.Graphics.FillRectangle(lb, this.ClientRectangle);


            //I don't know what here is needed to keep the cursor at the right position...
            e.Graphics.DrawString(this.Text, this.Font, sb, this.ClientRectangle);

        
        }

        


    }
}
