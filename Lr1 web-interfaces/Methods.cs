using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_web_interfaces
{
    internal class Methods
    {
        private String text = new StreamReader("Lorem Ipsum.txt").ReadToEnd();

        public void GetWords()
        {
            Console.Write("Введіть кількість слів: ");
            string input = Console.ReadLine();

            int count;
            if (!int.TryParse(input, out count))
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
                return;
            }

            String[] words = text.Split(' ');
            if (count > words.Length)
            {
                Console.WriteLine("Кількість слів перевищує кількість слів у тексті");
            }
            Console.WriteLine(String.Join(" ", words.Take(count)));
        }

        public void Calculate()
        {
            Console.Write("Введіть перше число: ");
            string input = Console.ReadLine();
            double a;
            if (!double.TryParse(input, out a))
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
                return;
            }
            Console.Write("Введіть друге число: ");
            input = Console.ReadLine();
            double b;
            if (!double.TryParse(input, out b))
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
                return;
            }
            Console.Write("Введіть операцію (+, -, *, /): ");
            String operation = Console.ReadLine();
            double result;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Помилка: Невірна операція.");
                    return;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
