﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel18.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шахматыDataSet.Специальные_шахматные_знаки". При необходимости она может быть перемещена или удалена.
            this.специальные_шахматные_знакиTableAdapter.Fill(this.шахматыDataSet.Специальные_шахматные_знаки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "шахматыDataSet.Шахматные_фигуры". При необходимости она может быть перемещена или удалена.
            this.шахматные_фигурыTableAdapter.Fill(this.шахматыDataSet.Шахматные_фигуры);

        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip2.Visible=true;
            menuStrip3.Visible = false;
            panel19.Visible = false;
            label474.BackColor = Color.DeepSkyBlue;
            panel20.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel19.Visible = false;
            panel25.Visible = false;
            panel17.Visible = false;
            panel18.Visible = true;//приветственный экран
        }

        private void ЗнакомствоСШахматнойДоскойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible=false;//панель "Как выиграть в шахматах"
            panel15.Visible = false;//панель "Запись партий в шахматах"
            panel14.Visible = false;//панель "Ничья в шахматах"
            panel13.Visible = false;//панель "Мат в шахматах"
            panel12.Visible = false;//панель "Шах в шахматах"
            panel11.Visible = false;//панель "Взятие на походе"
            panel10.Visible = false;//панель "Рокировка в шахматах"
            panel9.Visible = false;//панель "Король"
            panel8.Visible = false;//панель "Ферзь"
            panel7.Visible = false;//панель "Ладья"
            panel6.Visible = false;//панель "Слон"
            panel1.Visible = false;//панель "Конь"
            panel5.Visible = false;//панель "Пешка"
            panel4.Visible = false;//панель "Знакомство с шахматными фигурами"
            panel2.Visible = true;//панель "Знакомство с шахматной доской"
            menuStrip3.Visible = false;//меню для тренажера
            panel18.Visible = false;//приветственный экран
        }

        private void знакомствоСШахматнымиФигурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = true;
            panel2.Visible = false;
            menuStrip3.Visible = false;
            panel18.Visible = false;

        }

        private void пешкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = true;
            panel18.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void коньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = true;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void слонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel18.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = true;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void ладьяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel18.Visible = false;
            panel8.Visible = false;
            panel7.Visible = true;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void ферзьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = true;
            panel18.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void корольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel18.Visible = false;
            panel9.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;

        }

        private void рокировкаВШахматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel18.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = true;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void взятиеНаПроходеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel18.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = true;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void шахВШахматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel18.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = true;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;
        }

        private void матВШахматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = true;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel18.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            menuStrip3.Visible = false;

        }

        private void ничьяВШахматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = true;
            menuStrip3.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel18.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void записьПартийВШахматахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel15.Visible = true; 
            menuStrip3.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel18.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
        }
        
        private void какВыигратьВШахматыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            menuStrip3.Visible = false; 
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel18.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            menuStrip3.Visible = true;
            label474.BackColor = Color.MediumTurquoise;
            menuStrip1.BackColor = Color.MediumTurquoise;
            menuStrip2.Visible = false;
            panel18.Visible = true;//приветственный экран
            panel16.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tren3 tren3= new Tren3();//объявляем объект класса Tren3 для открытия новой формы
            tren3.Show();//открываем другую форму
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;//панель "Знакомство с шахматной доской. Тренажер" 
            panel25.Visible = false;//панель "Как ходят фигуры?  Тренажер"
            panel24.Visible = false;//панель "Рокировка в шахматах. Тренажер"
            panel23.Visible = false;//панель "Мат в шахматах. Тренажер"
            panel18.Visible = false;//приветственный экран
            panel17.Visible = false;//панель "Ничья в шахматах. Тренажер"
            panel20.Visible = false;//панель "Запись партий. Тренажер"
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            panel19.Visible = false;
            panel25.Visible = true;
            panel24.Visible = false;
            panel23.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel20.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tren9 tren9 = new Tren9();
            tren9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tren8 tren8 = new Tren8();
            tren8.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            panel24.Visible = true;
            panel19.Visible = false;
            panel18.Visible = false;
            panel25.Visible = false;
            panel23.Visible = false;
            panel17.Visible = false;
            panel20.Visible = false;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            panel23.Visible = true;
            panel24.Visible = false;
            panel19.Visible = false;
            panel25.Visible = false;
            panel18.Visible = false;
            panel20.Visible = false;
            panel17.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tren7 tren7= new Tren7();
            tren7.Show();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tren4 tren4 = new Tren4();
            tren4.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            panel20.Visible = true;
            panel23.Visible = false;
            panel24.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel25.Visible = false;
            panel17.Visible = false;
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Tren1 tren1 = new Tren1();
            tren1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            panel23.Visible = false;
            panel18.Visible = false;
            panel24.Visible = false;
            panel19.Visible = false;
            panel25.Visible = false;
            panel17.Visible = true;
        }
    }
}
