using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                switch (c)
                {
                    case '}':
                        if (stack.Pop() != '{')
                        {
                            Console.WriteLine("Лишняя закрывающая скобка '}'");
                        }
                        break;
                    case ']':
                        if (stack.Pop() != '[')
                        {
                            Console.WriteLine("Лишняя закрывающая скобка ']'");
                        }
                        break;
                    case ')':
                        if (stack.Pop() != '(')
                        {
                            Console.WriteLine("Лишняя закрывающая скобка ')'");
                        }
                        break;
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(c);
                        break;
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("Не найдена закрывающая скобка для " + stack.Pop());
            }
            else
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            Console.ReadKey();
        }
    }
}
