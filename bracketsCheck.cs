using System;
using System.Collections.Generic;
using System.Linq;

namespace bracketsCheck
{
    class Program
    {
        private static int CheckBrackets(string s)
        {
            int bracketCounter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i]) // проверка условий открытия, закрытия скобок
                {
                    case '(':
                        bracketCounter++;
                        break;
                    case ')':
                        bracketCounter--;
                        break;
                    case '{':
                        bracketCounter++;
                        break;
                    case '}':
                        bracketCounter--;
                        break;
                    case '[':
                        bracketCounter++;
                        break;
                    case ']':
                        bracketCounter--;
                        break;
                }

                if (bracketCounter < 0) //проверяем количество закрывающих скобок не превышают открывающих
                {
                    return i;
                }
            }

            if (bracketCounter != 0)// если остались значения, значит не хватает закрывающих или открывающих скобок
            {
                return s.Length;
            }

            return -1; // все хорошо
        }

        static void Main(string[] args)
        {
            string s = "{},(),[]";
            Console.WriteLine(s + "\t" + CheckBrackets(s));
            Console.ReadLine();
        }
    }
}
