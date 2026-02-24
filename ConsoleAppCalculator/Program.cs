namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Завдання 1. Введiть два числа та виберiть операцiю (додавання (+), вiднiмання (-), множення(*), дiлення(/)):");

                try
                {
                    Console.WriteLine("Введiть перше число:");
                    firstValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введiть друге число:");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка: Введiть коректне число.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Виберiть операцiю натиснувши на клавiатурi (+, -, *, /):");
                ConsoleKey operationKey = Console.ReadKey().Key;

                switch (operationKey)
                {
                    case ConsoleKey.Add:
                        Console.WriteLine("\nРезультат: " + (firstValue + secondValue));
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("\nРезультат: " + (firstValue - secondValue));
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine("\nРезультат: " + (firstValue * secondValue));
                        break;
                    case ConsoleKey.Divide:
                        if (firstValue != 0 && secondValue != 0)
                        {
                            Console.WriteLine("\nРезультат: " + (firstValue / secondValue));
                        }
                        else
                        {
                            Console.WriteLine("\nПомилка: Дiлення на нуль неможливе.");
                        }
                        break;
                    default:
                        Console.WriteLine("\nНевiрна операцiя. Будь ласка, виберiть одну з наступних операцiй: +, -, *, /");
                        break;
                }

            }
        }
    }
}