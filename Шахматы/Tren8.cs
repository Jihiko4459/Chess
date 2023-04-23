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
    public partial class Tren8 : Form
    {
        public Tren8()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string varotvet1 = textBox1.Text, varotvet2 = textBox2.Text,
                varotvet3 = textBox3.Text, varotvet4 = textBox4.Text, varotvet5 = textBox5.Text, varotvet6=textBox6.Text,
                varotvet7=textBox10.Text, varotvet8=textBox9.Text, varotvet9=textBox8.Text, varotvet10=textBox7.Text,
                varotvet11=textBox11.Text;
            string otvet1 = "3", otvet2 = "пат", otvet3 = "пат", otvet4 = "пат",
                otvet5 = "пат", otvet6="плохой", otvet7="пат", otvet8="мат", 
                otvet9="пат", otvet10="пат", otvet11="пат";
            int ball = 0;
            if (varotvet1 == otvet1)
            {
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
                textBox10.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }
            if (varotvet8 == otvet8)
            {
                textBox9.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
            if (varotvet9 == otvet9)
            {
                textBox8.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }
            if (varotvet10 == otvet10)
            {
                textBox7.BackColor = Color.White;
                ball++;
            }
            else
            {
                textBox7.BackColor = Color.Red;
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
            if (ball == 11)
            {
                MessageBox.Show("Молодец!");
                this.Close();
            }
            else { MessageBox.Show("У тебя ошибки! Исправь!"); }
        }
    }
}
