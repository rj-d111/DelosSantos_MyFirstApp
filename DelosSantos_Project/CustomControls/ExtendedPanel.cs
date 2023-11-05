using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.CustomControls
{
    public class ExtendedPanel : Panel
    {
        private const int FADE_INTERVAL = 50;
        private const int FADE_STEP = 10;

        private Timer fadeTimer = new Timer();
        private int opacity = 0;
        public override  Color BackColor {  get; set; } = Color.FromArgb(162, 37, 47);

        public ExtendedPanel()
        {
            base.BackColor = Color.Transparent;
            fadeTimer.Interval = FADE_INTERVAL;
            fadeTimer.Tick += new EventHandler(fadeTimer_Tick);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            fadeTimer.Start();
            base.OnMouseEnter(e);
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.opacity >= 100)
            {
                fadeTimer.Stop();
            }
            else
            {
                this.opacity += FADE_STEP;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(255,BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }


}
