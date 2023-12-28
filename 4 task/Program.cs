using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи для вывода: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintFibonacciSeries(n);
    }

    static void PrintFibonacciSeries(int count)
    {
        int first = 0, second = 1;

        Console.WriteLine($"Первые {count} чисел ряда Фибоначчи:");

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{first} ");

            int temp = first + second;
            first = second;
            second = temp;
        }
    }
}
