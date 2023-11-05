using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Resources
{
    public interface ISidePanel
    {
        void ResetColorAll();
        void HoveredPart(Panel panel, Label label);
        
    }
}
