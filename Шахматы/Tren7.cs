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
    public partial class Tren7 : Form
    {
        public Tren7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string varotvet1 = textBox2.Text, varotvet2 = textBox3.Text,
                varotvet3 = textBox4.Text, varotvet4 = textBox5.Text,
                varotvet5 = textBox7.Text, varotvet6 = textBox6.Text,
                varotvet7 = textBox1.Text, varotvet8 = textBox10.Text,
                varotvet9 = textBox9.Text, varotvet10 = textBox8.Text;
               
            string otvet1 = "шах", otvet2 = "мат", otvet3 = "шах", otvet4 = "мат",
                otvet5 = "g4", otvet6 = "Сd5", otvet7 = "Лe8", otvet8 = "Кf7",
                otvet9 = "Сg2", otvet101 = "Фe2", otvet102="Фa1";
            int ball = 0;
            if (varotvet1 == otvet1)
            {
                ball++;
                textBox2.BackColor = Color.White;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (varotvet2 == otvet2)
            {
                ball++;
                textBox3.BackColor = Color.White;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (varotvet3 == otvet3)
            {
                textBox4.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (varotvet4 == otvet4)
            {
                textBox5.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
            if (varotvet5 == otvet5)
            {
                textBox7.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
            if (varotvet6 == otvet6)
            {
                textBox6.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
            if (varotvet7 == otvet7)
            {
                textBox1.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (varotvet8 == otvet8)
            {
                textBox10.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }
            if (varotvet9 == otvet9)
            {
                textBox9.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
            if (varotvet10 == otvet101 || varotvet10==otvet102)
            {
                textBox8.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }
            if (ball == 10)
            {
                MessageBox.Show("Молодец!");
                this.Close();
            }
            else { MessageBox.Show("У тебя ошибки! Исправь!"); }
        }
    }
}
