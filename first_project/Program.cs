using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class Program
    {
        static void Main()
        {
            int i = 0;
            Console.WriteLine("Введите сумму вклада:");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int month = Convert.ToInt32(Console.ReadLine());

            while (i <= month)
            {
                i++;
                double result = sum * 7 / 100;
                if (i == month) Console.WriteLine(sum + result);
            }
        }
    }
}
