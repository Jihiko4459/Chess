using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шахматы
{
    public partial class Tren9 : Form
    {
        public Tren9()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string varotvet1=textBox1.Text,  varotvet2 = textBox2.Text, 
                varotvet3 = textBox3.Text, varotvet4 = textBox4.Text, varotvet5 = textBox6.Text;
            string otvet1 = "1.Лg5 Кh7 2.Кf7",
                otvet21 = "1.Лg3+ Кf2 2.Лg2+ Кf1 3.Лg1+ Кe2 4.Лg2+ Кe3 5.Лg3+Кe4 6.Лg4",
                otvet22 = "1.Лg3+ Кf2 2.Лg2+ Кf1 3.... К:g1 4.Лg2+ Кe3 5.Лg3+Кe4 6.Лg4",
                otvet3 = "", otvet4 = "", otvet5 = "";
        }
    }
}
