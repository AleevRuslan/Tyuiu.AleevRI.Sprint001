using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint1.Task4.V17.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Class Math                                                     *");
            Console.WriteLine("* Задание #1.4                                                         *");
            Console.WriteLine("* Вариант #18                                                          *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУБ-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает результат          *");
            Console.WriteLine("* на экране.                                                           *"); 
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

            Console.WriteLine("1 / sqrt(x - 5y) = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
