using System;

class Program
{
    static void Main()
    {
        
        int seed = 123;
        PseudoRandom pseudoRandom = new PseudoRandom(seed);

        // Вычисление CRC-16/RIELLO для ряда случайных чисел
        int[] randomNumbers = new int[5]; 
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = pseudoRandom.Next(0, 255); 
        }

        ushort crc = CalculateCRC16Riello(randomNumbers);

        // Вывод результата
        Console.WriteLine($"CRC-16/RIELLO для ряда случайных чисел: 0x{crc:X4}");
    }

    static ushort CalculateCRC16Riello(int[] numbers)
    {
        ushort crc = 0x0000;
        ushort polynomial = 0x1021;
        bool initialValue = true;

        foreach (var number in numbers)
        {
            crc ^= (ushort)(number << 8);

            for (int i = 0; i < 8; i++)
            {
                if ((crc & 0x8000) != 0)
                {
                    crc = (ushort)((crc << 1) ^ polynomial);
                }
                else
                {
                    crc <<= 1;
                }
            }
        }

        if (initialValue)
        {
            crc ^= 0xFFFF;
        }

        return crc;
    }
}

class PseudoRandom
{
    private int seed;
    private const int a = 1664525;
    private const int c = 1013904223;
    private const int m = int.MaxValue;

    public PseudoRandom(int seed)
    {
        this.seed = seed;
    }

    public int Next(int minValue, int maxValue)
    {
        seed = (a * seed + c) % m;
        return (int)((seed / (double)m) * (maxValue - minValue + 1)) + minValue;
    }
}
