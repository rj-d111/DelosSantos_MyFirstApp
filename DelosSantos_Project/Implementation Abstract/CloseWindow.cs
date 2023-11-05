using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelosSantos_Project.Implementations.Inherited
{
    public class CloseWindow : IButtonWindow
    {
        public void CloseHandler()
        {
            Environment.Exit(0);
        }
    }
}
