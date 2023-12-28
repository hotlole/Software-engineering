using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_task
{
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
    internal class Program
    {
        static void Main(string[] args)
        { 

            //используем уже имеющийся класс
            int a;
            a = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < a; i++) 
            {
                Console.WriteLine(random.Next());
            }


            //созданный мною класс
            int seed = 123; 
            PseudoRandom pseudoRandom = new PseudoRandom(seed);

            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(pseudoRandom.Next(1, 100));
            }

        }
    }
}
