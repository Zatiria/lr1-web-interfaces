using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1_web_interfaces
{
    internal class Methods
    {
        public void GetWords()
        {
            Console.Write("Введіть кількість слів: ");
            int count = Convert.ToInt32(Console.ReadLine());

            using StreamReader reader = new("Lorem Ipsum.txt");
            String text = reader.ReadToEnd();
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
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть операцію (+, -, *, /): ");
            String operation = Console.ReadLine();
            String res = "";
            switch (operation)
            {
                case "+":
                    res = (a + b).ToString();
                    break;
                case "-":
                    res = (a - b).ToString();
                    break;
                case "*":
                    res = (a * b).ToString();
                    break;
                case "/":
                    res = (a / b).ToString();
                    break;
                default:
                    res =  "Невірна операція";
                    break;
            }
            Console.WriteLine("Результат: " + res);
        }
    }
}
