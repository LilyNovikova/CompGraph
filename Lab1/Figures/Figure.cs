using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Figures
{
   public abstract class Figure
    {
        public abstract void Draw(Graphics g, Control control, Color color);
    }
}
