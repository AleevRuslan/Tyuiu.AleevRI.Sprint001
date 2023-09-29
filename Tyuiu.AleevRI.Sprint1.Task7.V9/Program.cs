using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AleevRI.Sprint1.Task7.V9.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
            Console.WriteLine("* Задание #1.7                                                         *");
            Console.WriteLine("* Вариант #9                                                           *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУБ-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*              2      3                    2                           *");
            Console.WriteLine("*       x     y + cosx + 12 * x * y - 3 * x                            *");
            Console.WriteLine("* z =  e  - --------------------------------                           *");
            Console.WriteLine("*                       3                                              *");
            Console.WriteLine("*                 cos (x + 3) + 18 * y - 1                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
