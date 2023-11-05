using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.CustomControls
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 10; // Set the desired corner radius

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, Width, Height);

            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, CornerRadius * 2, CornerRadius * 2, 180, 90); // Top-left corner
            path.AddArc(bounds.Right - CornerRadius * 2, bounds.Top, CornerRadius * 2, CornerRadius * 2, 270, 90); // Top-right corner
            path.AddArc(bounds.Right - CornerRadius * 2, bounds.Bottom - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90); // Bottom-right corner
            path.AddArc(bounds.Left, bounds.Bottom - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Fill the panel with a background color (if needed)
            graphics.FillPath(new SolidBrush(this.BackColor), path);

            // Draw the border of the rounded panel (if needed)
            graphics.DrawPath(new Pen(this.BackColor, 1), path);

            // Set the region of the panel to the rounded path
            this.Region = new Region(path);
        }
    }
}
