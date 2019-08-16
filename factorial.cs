using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciclenum = 10;
            int x = 5;
            int fact = 1;

            for (int i = x; i <= ciclenum; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Факториал от " + x + " до " + ciclenum + " = " + fact);
            Console.ReadLine();
        }
    }
}
