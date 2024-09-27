using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint4.Task3.V6.Lib;

namespace Tyuiu.DonskoiIA.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (Статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя массив 5 на 5,     *");
            Console.WriteLine("* затем она находит максимальный элемент на его второй строке и выводит   *");
            Console.WriteLine("* его на экран                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите массив построчно:");

            int[,] arr = new int[5,5];

            for (int i = 0; i < 5; i++)
            {
                string[] t = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = int.Parse(t[j]);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(arr));

            Console.ReadLine();
        }
    }
}