using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //guzik od kwadrata
        {
            Kwadrat kwadrat1 = new Kwadrat();
            int a = (int)numericUpDown6.Value;
            MessageBox.Show("Wynik: " + kwadrat1.poleKwadratu(a)); //wyswietlenie okienka z wynikiem
        }

        private void button2_Click(object sender, EventArgs e) //guzik od prostokata
        {
            Prostokat prostokat1 = new Prostokat();
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            MessageBox.Show("Wynik: " + prostokat1.poleProstokatu(a, b)); //wyswietlenie okienka z wynikiem
        }

        private void button3_Click(object sender, EventArgs e) //guzik od trojkata
        {
            Trojkat trojkat1 = new Trojkat();
            double a = (double)numericUpDown3.Value;
            double h = (double)numericUpDown4.Value;
            MessageBox.Show("Wynik: " + trojkat1.poleTrojkat(a, h)); //wyswietlenie okienka z wynikiem
        }

        private void button4_Click(object sender, EventArgs e) //guzik od okręgu
        {
            Okrag okrag1 = new Okrag();
            double a = (double)numericUpDown5.Value;
            MessageBox.Show("Wynik: " + okrag1.poleOkregu(a)); //wyswietlenie okienka z wynikiem
        }

      
    }
}
