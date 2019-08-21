using System;
using System.Linq;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = "zero one zero jack one superuser";

            Console.WriteLine($"В введенной строке: \"words\",\n");

            foreach (var group in words.Split(' ').GroupBy(word => word))
            {
                Console.WriteLine($"Слово '{group.Key}' повторилось {group.Count()} раз");
            }

            Console.ReadLine();
        }
    }
}
