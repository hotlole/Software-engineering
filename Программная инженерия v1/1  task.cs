using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программная_инженерия_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("введите 2 целых числа");
            string input_a = Console.ReadLine();
            string input_b = Console.ReadLine();
            a = int.Parse(input_a);
            b = int.Parse(input_b);
            Console.WriteLine("Сумма " + (a + b));
            Console.WriteLine("Разность " + (a - b));
            Console.WriteLine("Произведение " + (a * b));
            Console.WriteLine("Частное " + (a / b));

            double x, y;
            Console.WriteLine("введите 2 вещественных числа");
            string input_x = Console.ReadLine();
            string input_y = Console.ReadLine();
            x = double.Parse(input_x);
            y = double.Parse(input_y);
            Console.WriteLine("Сумма " + (x + y));
            Console.WriteLine("Разность " + (x - y));
            Console.WriteLine("Произведение " + (x * y));
            Console.WriteLine("Частное " + (x / y));



        }
    }
}
