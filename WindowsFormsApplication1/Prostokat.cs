using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Prostokat
    {
        public int poleProstokatu(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return -1;
            }
            else
            {
                return a * b;
            }
        }
    }
}
