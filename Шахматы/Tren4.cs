using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Шахматы
{
    public partial class Tren4 : Form
    {
        public Tren4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string varotvet11 = textBox2.Text, varotvet12 = textBox1.Text,
                varotvet21 = textBox4.Text, varotvet22 = textBox3.Text,
            varotvet31 = textBox6.Text, varotvet32 = textBox5.Text,
            varotvet41 = textBox8.Text, varotvet42 = textBox7.Text;

            string otvet1 = "длинная и короткая рокировки", otvet2 = "длинная и короткая рокировки", otvet3 = "короткая рокировка", otvet4 = "короткая рокировка",
                otvet5 = "не могут сделать рокировку", otvet6 = "длинная и короткая рокировки", otvet7 = "длинная и короткая рокировки", otvet8 = "не могут сделать рокировку";
            int ball = 0;
            if (varotvet11 == otvet1)
            {
                ball++;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (varotvet12 == otvet2)
            {
                ball++;
                textBox2.BackColor = Color.White;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (varotvet21 == otvet3)
            {
                textBox3.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (varotvet22 == otvet4)
            {
                textBox4.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (varotvet31 == otvet5)
            {
                textBox5.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
            if (varotvet32 == otvet6)
            {
                textBox6.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
            if (varotvet41 == otvet7)
            {
                textBox7.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
            if (varotvet42 == otvet8)
            {
                textBox8.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }
            if (ball == 8)
            {
                MessageBox.Show("Молодец!");
                this.Close();
            }
            else { MessageBox.Show("У тебя ошибки! Исправь!"); }
        }
    }
}

