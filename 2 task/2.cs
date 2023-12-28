using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите угол (в градусах или радианах): ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Перевод угла в радианы, если он в градусах
        double angleInRadians = angle * Math.PI / 180;

        // Одинарная точность (Single - 32 бита)
        CalculateAndPrintResults("Одинарная точность (32 бита)", (float)angleInRadians);

        // Двойная точность (Double - 64 бита)
        CalculateAndPrintResults("Двойная точность (64 бита)", angleInRadians);

        // 4-кратная точность (Decimal - 128 бит)
        CalculateAndPrintResults("4-кратная точность (128 бит)", Convert.ToDouble((decimal)angleInRadians));
    }

    static void CalculateAndPrintResults(string precision, double angle)
    {
        Console.WriteLine($"\n{precision}");
        Console.WriteLine($"sin({angle}): {Math.Sin(angle)}");
        Console.WriteLine($"cos({angle}): {Math.Cos(angle)}");

        // tan и cotan определены только для double
        if (precision != "Одинарная точность (32 бита)")
        {
            Console.WriteLine($"tan({angle}): {Math.Tan(angle)}");
            Console.WriteLine($"cotan({angle}): {1 / Math.Tan(angle)}");
        }
        else
        {
            Console.WriteLine("tan и cotan недоступны для одинарной точности");
        }
    }
}
