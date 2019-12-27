using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крестики_нолики
{
    public partial class Form1 : Form
    {
        string turn = "";
        Random rnd = new Random();
        int[] mass = new int[9];
        Button[] btn = new Button[9];
        public Form1()
        {
            InitializeComponent();//Вносить кнопки в массив можно только после InitializeComponent()
            //Т.к. кнопки до этого метода не были инициализированны и программа их просто не увидит

            if (rnd.Next(1, 6) <= 3)//Проверяем случайное значени
            {//Если оно меньше или равно 3, то первыми ходят крестики
                turn = "Крестики";
                label1.Text = "Начинает X";
            }//А если больше 3, то ходят нолики
            else { turn = "Нолики"; label1.Text = "Начинает O"; }
            btn[0] = button1;//Внесли 1 кнопку в массив с номером элемента 0
            btn[1] = button2;//Внесли 2 кнопку в массив с номером элемента 1
            btn[2] = button3;//Внесли 3 кнопку в массив с номером элемента 2
            btn[3] = button4;//Внесли 4 кнопку в массив с номером элемента 3
            btn[4] = button5;//Внесли 5 кнопку в массив с номером элемента 4
            btn[5] = button6;//Внесли 6 кнопку в массив с номером элемента 5
            btn[6] = button7;//Внесли 7 кнопку в массив с номером элемента 6
            btn[7] = button8;//Внесли 8 кнопку в массив с номером элемента 7
            btn[8] = button9;//Внесли 9 кнопку в массив с номером элемента 8
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // restart
            for (int i = 0; i < btn.Length; i++)
            {
                mass[i] = 0;
                btn[i].Text = "";
                if (rnd.Next(1, 6) <= 3)
                {
                    turn = "Крестики";
                    label1.Text = "X";
                }
                else { turn = "Нолики"; label1.Text = "O"; }
                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void onclickonbutton(object sender, EventArgs e)
        {
            if (turn == "Крестики")//Если крестики
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])//то через условие сравниваем какая кнопка была нажата
                    {
                        btn[i].Text = "X";//Устанавливаем свойство text у этой кнопки на крестик
                        label1.Text = "Ходит O";//Устанавливаем свойство text у Label на нолик
                        turn = "Нолики";//Устанавливает переменную на нолик
                        btn[i].Enabled = false;//Делаем эту кнопку не воспиимчивой к кликам
                        mass[i] = 1;//Устанавливаем значение кнопки на 1 - то есть крестик
                        break;//Прерываем цикл чтобы он не повторялся после нахождения нужной кнопки
                    }
                }
            }
            else//Иначе
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])//то через условие сравниваем какая кнопка была нажата
                    {
                        btn[i].Text = "O";//Устанавливаем свойство text у этой кнопки на нолик
                        label1.Text = "Ходит X";//Устанавливаем свойство text у Label на крестик
                        turn = "Крестики";//Устанавливает переменную на крестик
                        btn[i].Enabled = false;//Делаем эту кнопку не воспиимчивой к кликам
                        mass[i] = 2;//Устанавливаем значение кнопки на 2 - то есть нолик
                        break;//Прерываем цикл чтобы он не повторялся после нахождения нужной кнопки
                    }
                }
            }


            if (mass[0] == 1 && mass[1] == 1 && mass[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[3] == 1 && mass[4] == 1 && mass[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[6] == 1 && mass[7] == 1 && mass[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[0] == 1 && mass[3] == 1 && mass[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[1] == 1 && mass[4] == 1 && mass[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[2] == 1 && mass[5] == 1 && mass[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[0] == 1 && mass[4] == 1 && mass[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }
            else if (mass[2] == 1 && mass[4] == 1 && mass[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили крестики";
            }




            else if (mass[0] == 2 && mass[1] == 2 && mass[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[3] == 2 && mass[4] == 2 && mass[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";

            }
            else if (mass[6] == 2 && mass[7] == 2 && mass[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[0] == 2 && mass[3] == 2 && mass[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[1] == 2 && mass[4] == 2 && mass[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[2] == 2 && mass[5] == 2 && mass[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[0] == 2 && mass[4] == 2 && mass[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
            else if (mass[2] == 2 && mass[4] == 2 && mass[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                { btn[i].Enabled = false; }
                button10.Enabled = true;
                label1.Text = "Победили нолики";
            }
        }
    }
}
