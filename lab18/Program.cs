using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLLECTIONS
{    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }

        static bool Check(string str)//Создаем метод для проверки условий
        {            
            Stack<char> stack = new Stack<char>();           
            Dictionary<char, char> sk = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
            };
            //Перебираем посимвольно строку
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(sk[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                        return false;
                }
            }            
            if (stack.Count == 0)
                return true;
            else
                return false;//количество открытых скобок превышает количество закрытых
        }
    }
}
