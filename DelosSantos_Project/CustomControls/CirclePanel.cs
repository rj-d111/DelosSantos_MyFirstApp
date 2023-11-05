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
    public class CirclePanel : Panel
    {
        public Color ColorTop { get; set; } = Color.FromArgb(173, 25, 25);
        public Color ColorBottom { get; set; } = Color.FromArgb(41, 0, 0);
        public float Angle { get; set; } = 90f;

        public CirclePanel()
        {
            BackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           // e.Graphics.DrawEllipse(Pens.Black, 0, 0, Width - 1, Height - 1);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
            Region r = new Region(gp);
            Graphics gr = e.Graphics;

            LinearGradientBrush brushes = new LinearGradientBrush(ClientRectangle, ColorTop,ColorBottom,Angle);
            gr.FillRegion(brushes, r);
        }

    }

}
