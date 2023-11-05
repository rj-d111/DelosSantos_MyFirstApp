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
    public class CustomRadioButton : RadioButton
    {
        //Fields
        public Color CheckedColor { get; set; } = Color.FromArgb(173, 25, 25); //Red Color
        public Color UnCheckedColor { get; set; } = Color.FromArgb(240,240,240); // Gray Color

        public new Padding Padding { get; set; } = new Padding(10, 0, 0, 0);
        public CustomRadioButton() 
        {
            this.MinimumSize = new Size(0, 21);
            //Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            //this.Padding = new Padding(10, 0, 0, 0);

            Font font = new Font("Segoe UI", 12);
            this.Font = font;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            // Change the font style based on whether the radio button is checked
            if (this.Checked)
            {
                // Set bold font
                this.Font = new Font(this.Font, FontStyle.Bold);
            }
            else
            {
                // Set regular font
                this.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Fields
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2, //Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), //Center
                Y = (this.Height - rbCheckSize) / 2, //Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            //Drawing
            using (Pen penBorder = new Pen(CheckedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(CheckedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                //Draw surface
                graphics.Clear(this.BackColor);
                //Draw Radio Button
                if (this.Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);//Circle border
                    graphics.FillEllipse(brushRbCheck, rectRbCheck); //Circle Radio Check
                }
                else
                {
                    penBorder.Color = UnCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); //Circle border
                }
                //Draw text
                graphics.DrawString(this.Text, this.Font, brushText,
                    rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);//Y=Center
            }
        }
        //X-> Obsolete code, this was replaced by the Padding property in the constructor
        //(this.Padding = new Padding(10,0,0,0);)
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        //}

    }
}
