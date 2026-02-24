namespace ConsoleForPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
           
                Console.WriteLine("Завдання 1. Введiть висоту піраміди:");
                try
                {
                    height = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка: Введiть коректне ціле число.");
                    Console.ReadLine();
                    return;
                }

            for (int i = 1; i <= height; i++)
            {
                for (int j=0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = height - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = height - 1; i > 0; i--)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
