using Lr1_web_interfaces;

Console.WriteLine("Виберіть пункт меню:");
Console.WriteLine("1. Вивести вказану кількість слів з тексту");
Console.WriteLine("2. Виконати математичну операцію");

Console.Write("Ваш вибір: ");
String choise = Console.ReadLine();

Methods methods = new Methods();

switch (choise)
{
    case "1":
        methods.GetWords();
        break;
    case "2":
        methods.Calculate();
        break;
    default:
        Console.WriteLine("Невірний вибір");
        break;
}