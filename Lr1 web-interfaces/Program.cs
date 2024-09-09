using Lr1_web_interfaces;
using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;

bool exit = false;
Methods methods = new Methods();
do
{
    Console.WriteLine("");
    Console.WriteLine("Виберіть пункт меню:");
    Console.WriteLine("1. Вивести вказану кількість слів з тексту");
    Console.WriteLine("2. Виконати математичну операцію");
    Console.WriteLine("3. Вийти з програми");

    Console.Write("Ваш вибір: ");
    String choise = Console.ReadLine();

    switch (choise)
    {
        case "1":
            methods.GetWords();
            break;
        case "2":
            methods.Calculate();
            break;
        case "3":
            exit = true;
            break;
        default:
            Console.WriteLine("Невірний вибір");
            break;
    }
} while (!exit);