using System; //important
using System.Collections.Generic;
using System.Linq; 
using System.Runtime.InteropServices; //important
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // important

namespace DelosSantos_Project.CustomControls
{
    public class RoundedForms
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );

        public static void ApplyRoundedRegion(Form form, int width, int height, int ellipseWidth, int ellipseHeight)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, ellipseWidth, ellipseHeight));
        }
    }
}
