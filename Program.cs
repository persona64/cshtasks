using System;

namespace Sort
{
    class Program
    {

        static int[] bubblesort(int[] array)
        {
            // сортировка пузырьком, выполняется путем сравнения двух чисел и выбора наименьшего

            int num;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        num = array[i];
                        array[i] = array[j];
                        array[j] = num;
                    }
                }
            }
            return array;
        }

        static int func(int num, int[] arr)
        {
            // метод поиска значения входящего или не входящего в массив
            for (int k = 0; k < arr.Length; k++)
            {
                if (num == arr[k]) return 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[9] { 12, 23, 41, 93, 123, 213, 32, 90, 1234 }; // инициализированный массив 

            /* здесь создается массив с рандомными значениями, проверку проходил
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(225);
            } */

            bubblesort(arr); 

            Console.WriteLine("После сортировки");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int num = 213;

            int index = System.Array.IndexOf(arr, num);

            if (index < 0)
            { 
                Console.WriteLine("Число " + num + " не входит в массив");
            }
            else
            {
                Console.WriteLine("Число " + num + " входит в массив");
            }
            Console.ReadLine();

        }
    }
}
