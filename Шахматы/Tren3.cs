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
    public partial class Tren3 : Form
    {
        public System.Windows.Forms.Button[,] butts = new System.Windows.Forms.Button[8, 8];
        public Tren3()
        {
            InitializeComponent();
            CreateBoard();
        }
        int size = 50;
        void CreateBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j] = new System.Windows.Forms.Button();
                    butts[i, j].Size = new Size(size, size);
                    butts[i, j].Location = new Point(i * size, j * size);
                    if ((i + j) % 2 == 0) butts[i, j].BackColor = Color.Chocolate;
                    else butts[i, j].BackColor = Color.Bisque;

                    this.Controls.Add(butts[i, j]);
                }
            }
        }
        void Ladiya(int a, int b, int c, int d)
        {
            if (a == c || b == d) MessageBox.Show("Вы можете ходить ладьей");
            else MessageBox.Show("Ладья так не ходит!");
        }
        void King(int a, int b, int c, int d)
        {
            if ((Math.Abs(c - a) == 1 && Math.Abs(d - b) <= 1) || (Math.Abs(c - a) <= 1 && Math.Abs(d - b) == 1))
                MessageBox.Show("Вы можете ходить королем");
            else MessageBox.Show("Король так не ходит!");
        }
        void Elephant(int a, int b, int c, int d)
        {
            if (Math.Abs(a - c) == Math.Abs(b - d)) MessageBox.Show("Вы можете ходить слоном");
            else MessageBox.Show("Слон так не ходит!");
        }
        void Ferz(int a, int b, int c, int d)
        {
            if ((Math.Abs(a - c) == Math.Abs(b - d)) || (a == c || b == d)) MessageBox.Show("Вы можете ходить ферзем");
            else MessageBox.Show("Ферзь так не ходит");
        }
        void Horse(int a, int b, int c, int d)
        {
            if ((Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2) || (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1))
                MessageBox.Show("Вы можете ходить конем");
            else MessageBox.Show("Конь так не ходит");
        }
        void Pawn(int a, int b, int c, int d)
        {
            if (Math.Abs(a - c) == 1 && Math.Abs(b - d) == 1)
                MessageBox.Show("Вы можете ходить пешкой");
            else MessageBox.Show("Пешка так не ходит");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;//х1
            string y1 = textBox2.Text;//у1
            string x2 = textBox3.Text;//х2
            string y2 = textBox4.Text;//у2
            if (x1.Length > 0&&y1.Length>0&&x2.Length>0&&y2.Length>0) { //проверка на пустоту полей
                Ladiya(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox2.Text;
            string x2 = textBox3.Text;
            string y2 = textBox4.Text;
            if (x1.Length > 0 && y1.Length > 0 && x2.Length > 0 && y2.Length > 0)
            {
                Ferz(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox2.Text;
            string x2 = textBox3.Text;
            string y2 = textBox4.Text;
            if (x1.Length > 0 && y1.Length > 0 && x2.Length > 0 && y2.Length > 0)
            {
                King(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox2.Text;
            string x2 = textBox3.Text;
            string y2 = textBox4.Text;
            if (x1.Length > 0 && y1.Length > 0 && x2.Length > 0 && y2.Length > 0)
            {
                Elephant(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox2.Text;
            string x2 = textBox3.Text;
            string y2 = textBox4.Text;
            if (x1.Length > 0 && y1.Length > 0 && x2.Length > 0 && y2.Length > 0)
            {
                Horse(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text;
            string y1 = textBox2.Text;
            string x2 = textBox3.Text;
            string y2 = textBox4.Text;
            if (x1.Length > 0 && y1.Length > 0 && x2.Length > 0 && y2.Length > 0)
            {
                Pawn(Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
        }
    }
}
