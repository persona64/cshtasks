using System;
using System.Collections.Generic;
using System.Linq;

namespace bracketsCheck
{
    class Program
    {
        class BracketsChecker
        {

            private readonly string _opening = "([{"; 
            private readonly string _closing = ")]}";

            private bool _cantBeBalanced;

            private Stack<int> _opened = new Stack<int>();  

            public bool Balanced => !_cantBeBalanced && !_opened.Any();

            public void Put(char ch)    
            {
                if (_cantBeBalanced) return;

                int index = _opening.IndexOf(ch);

                if(index != -1)
                {
                    _opened.Push(index);
                    return;
                }

                index = _closing.IndexOf(ch);

                if(index != -1)
                {
                    if(!_opened.Any() || _opened.Peek() != index)
                    {
                        _cantBeBalanced = true;
                        _opened.Clear();
                        _opened.TrimExcess();
                        return;
                    }

                    _opened.Pop();
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            var str = "{},(),[]";
            var checker = new BracketsChecker();

            foreach (var ch in str)
            {
                checker.Put(ch);
            }

            Console.WriteLine(checker.Balanced);
            Console.ReadLine();
        }
    }
}
