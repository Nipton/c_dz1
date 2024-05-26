namespace c__dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Неверное количество аргументов.");
                return;
            }
            double a, b, result;
            if (!double.TryParse(args[0], out a))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }
            if (!double.TryParse(args[2], out b))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }
            char operation = char.Parse(args[1]);
            
            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Неизвестная операция.");
                    return;
            }
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }
    }
}