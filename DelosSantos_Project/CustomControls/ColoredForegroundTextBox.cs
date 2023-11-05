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
    public class ColoredForegroundTextBox : TransparentBackgroundTextBox
    {
    
        public List<Color> ColorTexts { get; set; } = new List<Color>() { Color.FromArgb(255,255,255), Color.FromArgb(0, 255, 128),};
        // Declare the properties for the background gradient colors
        public ColoredForegroundTextBox() {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // For foreground text
            using(LinearGradientBrush foregroundGradientBrush = new LinearGradientBrush(
                new Point(0,10), new Point(10,20),Color.Red, Color.Violet
                ))
            {
              //  Color[] colors = ColorText;
                //int num_colors = colors.Length;


                //Change this to array
                Color[] color2 = ColorTexts.ToArray();

                //Color[] color2 = new Color[]
                //{
                //   Color.FromArgb(0, 255, 128),
                //   Color.FromArgb(0, 255, 244),

                //};

                int nums_colors = color2.Length;
                float[] blend_positions2 = new float[nums_colors];

                for(int i = 0; i < nums_colors; i++)
                {
                    blend_positions2[i] = i / (nums_colors - 1f);
                }



                //float[] blend_positions = new float[num_colors];
                //for (int i = 0; i < num_colors; i++)
                //{
                //    blend_positions[i] = i / (num_colors - 1f);
                //}



                ColorBlend color_blend = new ColorBlend();
                color_blend.Colors = color2;
                color_blend.Positions = blend_positions2;
                foregroundGradientBrush.InterpolationColors = color_blend;

                // Draw the text
                e.Graphics.DrawString(this.Text, this.Font, foregroundGradientBrush, ClientRectangle);
            }

        }


    }
}
