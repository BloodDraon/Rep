using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛБ2
{
    class Demukron
    {
        int[,] matr; // массив для матрицы смежности
        int[] alpha = new int [7];
        bool[] udalen = new bool [7];
        public Demukron()
        {
            matr = new int[7, 7];
            matr[0, 1] = 1;
            matr[0, 2] = 1;
            matr[1, 3] = 1;
            matr[2, 1] = 1;
            matr[2, 3] = 1;
            matr[2, 5] = 1;
            matr[3, 4] = 1;
            matr[3, 5] = 1;
            matr[4, 5] = 1;
            matr[4, 6] = 1;
            matr[6, 5] = 1;
        }
        public void start(TextBox TB)//запуск алгоритма
        {
            for (int level = 0; neudalen(ref udalen); level++)
            {
                alpha_matr(ref matr);
                for (int i=0; i<7; i++)
                {
                    if (alpha[i] == 0)//если эл. второй матрицы 0
                    {
                        udalen[i] = true;
                        TB.Text += "Уровень " + level + ":" +(i + 1).ToString();//вывод
                    }
                }
                TB.Text += "\r\n";
            }
        }
        void alpha_matr(ref int[,] matr)//составление второй матрицы
        {
            for (int i=0; i<7; i++)//всем эл. присваиваем значение 0
            {
                alpha[i] = 0;
            }
            for (int j=0; j<7; j++)
            {
               if (udalen[j]==true)
                {
                    alpha[j] = -1;
                    continue;
                }          
                for (int i = 0; i < 7; i++)//если не удал. элемент равен 0
                {
                    if (udalen[i] == false)
                    {
                        if (matr[i, j] == 1)
                        {
                            alpha[j]++;//увеличиваем значение во второй матрице
                        }
                    }                    
                }                
            }
        }
        bool neudalen(ref bool[] udalen)//проверка остались ли неудалённые точки
        {            
          for (int i = 0; i < 7; i++)
            {
             if (udalen[i] == true)
               {
                return false;
               }               
            }
            return false;
        }
    }
}