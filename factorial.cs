using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int g = 1;

            for (int i = 1; x >= i; ++i)
            {
                g = g * i;
            }

            Console.WriteLine("Факториал введенного числа равен: " + g);
            Console.ReadLine();
        }
    }
}
