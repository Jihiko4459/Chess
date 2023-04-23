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
    public partial class Tren1 : Form
    {
        public Tren1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string varotvet1 = textBox2.Text, varotvet2 = textBox1.Text,
                varotvet3 = textBox3.Text, varotvet4 = textBox4.Text,
                varotvet5 = textBox5.Text, varotvet6 = textBox6.Text,
                varotvet7 = textBox7.Text, varotvet8 = textBox8.Text,
                varotvet9 = textBox9.Text, varotvet10 = textBox10.Text,
                varotvet11=textBox11.Text, varotvet12=textBox12.Text,
                varotvet13=textBox13.Text, varotvet14=textBox14.Text,
                varotvet15=textBox15.Text, varotvet16=textBox16.Text,
                varotvet17=textBox17.Text;

            string otvet1 = "игрока", otvet2 = "квадрата", otvet3 = "белых", otvet4 = "черных",
                otvet5 = "64", otvet6 = "8", otvet7 = "2", otvet8 = "4",
                otvet9 = "7", otvet10 = "8", otvet11 = "8", otvet12 = "8",
                otvet13 = "одинаковое количество", otvet14 = "8", otvet15 = "b", otvet16 = "e",
                otvet17 = "g";
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
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Red;
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
                textBox5.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox5.BackColor = Color.Red;
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
                textBox7.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
            if (varotvet8 == otvet8)
            {
                textBox8.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox8.BackColor = Color.Red;
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
            if (varotvet10 == otvet10)
            {
                textBox10.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }
            if (varotvet11 == otvet11)
            {
                textBox11.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox11.BackColor = Color.Red;
            }
            if (varotvet12 == otvet12)
            {
                textBox12.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox12.BackColor = Color.Red;
            }
            if (varotvet13 == otvet13)
            {
                textBox13.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox13.BackColor = Color.Red;
            }
            if (varotvet14 == otvet14)
            {
                textBox14.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox14.BackColor = Color.Red;
            }
            if (varotvet15 == otvet15)
            {
                textBox15.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox15.BackColor = Color.Red;
            }
            if (varotvet16== otvet16)
            {
                textBox16.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox16.BackColor = Color.Red;
            }
            if (varotvet17 == otvet17)
            {
                textBox17.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox17.BackColor = Color.Red;
            }
            if (ball == 17)
            {
                MessageBox.Show("Молодец!");
                this.Close();
            }
            else { MessageBox.Show("У тебя ошибки! Исправь!"); }
        }
    }
}
