using System;
using System.Linq;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "zero, one, zero, Jack, one, superUser";
            var result = data.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries) // возвращаем массив подстрок в этой строке, также здесь задаем какие символы убираем из вывода
                .GroupBy(x => x) // группировка по заданным параметрам
                .Where(x => x.Count() == 1) // фильтр выборки
                .Select(x => x.Key); // проекция выбранных значений
            foreach (var item in result) Console.Write(item + " "); 
            Console.ReadLine();
        }
    }
}
