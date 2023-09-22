using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AleevRI.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Алеев Р. И. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                   *");
            Console.WriteLine("* Задание #1.3                                                         *");
            Console.WriteLine("* Вариант #8                                                           *");
            Console.WriteLine("* Выполнил: Алеев Руслан Ильнурович | АСОиУБ-23-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране.  *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            double startAmoun;

            Console.WriteLine("Введите величину вклада:");
            startAmoun = Convert.ToInt32(Console.ReadLine());

            double percent;

            Console.WriteLine("Введите процентную ставку:");
            percent = Convert.ToInt32(Console.ReadLine());

            double timeDays;

            Console.WriteLine("Введите срок вклада:");
            timeDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Сумма по окончании срока вклада = " + ds.IncomeAmount(startAmoun, percent, timeDays));

            Console.ReadLine();

        }
    }
}
