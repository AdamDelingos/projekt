﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Kwadrat
    {
        public int poleKwadratu(int a)
        {
            if (a < 0) // sprawdzenie czy podana liczba jest większa od zera
            {
                return -1;
            }
            else
            {
                return a * a; //wykonanie działania
            }
        }
    }
}
