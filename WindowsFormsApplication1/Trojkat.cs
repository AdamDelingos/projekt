using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Trojkat
    {
        public double poleTrojkat(double a, double h)
        {
            if (a < 0 || h < 0)
            {
                return -1;
            }
            else
            {
                return (a * h) / 2;
            }
        }
    }
}
