using System;
using System.Linq;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "zero one zero Jack one superUser";
            var result = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key);
            foreach (var item in result) Console.Write(item + " ");
            Console.ReadLine();
        }
    }
}
