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
        {//Кр Ф С Л К 
            string varotvet1=textBox1.Text,  varotvet2 = textBox2.Text, 
                varotvet3 = textBox3.Text, varotvet4 = textBox4.Text, varotvet5 = textBox6.Text;
            string otvet1 = "5. Лe5; 7. Крe7, Сg7; 8. Крg8",
                otvet2="2. Лg2; 3. Крe3, Крh3; 4. Фf4",
                otvet3 = "2. Крe2; 3. Лd3; 4. Сa4, Крe4; 5. Лd5", 
                otvet4 = "1. Лa1, Лf1, Крg1; 2. a2, b2, c2, f2, g2; 3. Фa3, Кc3, d3, h3; 4.Кe4; 6. Сb6, Сe6, Фg6; 7. a7, b7, c7, f7, g7, h7; 8. Лa8, Лf8, Крg8", 
                otvet5 = "1. Крa1, Лb1; 2. Лh2; 3. Крa3, b3; 6. g6; 7. Фf7, h7";
            int ball = 0;
            if (varotvet1 == otvet1) { 
                ball++;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (varotvet2 == otvet2)
            {
                ball++;
                textBox2.BackColor = Color.White;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (varotvet3 == otvet3)
            {
                textBox3.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (varotvet4 == otvet4)
            {
                textBox4.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (varotvet5 == otvet5)
            {
                textBox6.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
            if (ball == 5) {
                MessageBox.Show("Молодец!"); 
                this.Close(); 
            }
            else { MessageBox.Show("У тебя ошибки! Исправь!"); }
        }
    }
}
