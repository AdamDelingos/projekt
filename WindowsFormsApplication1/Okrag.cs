using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Okrag
    {
        public double poleOkregu(double r)
        {
            if (r < 0)
            {
                return -1;
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }
    }
}
