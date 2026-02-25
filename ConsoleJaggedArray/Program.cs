using System.Linq;

namespace ConsoleJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {6, 7, 8, 9}
            };

            Console.WriteLine("Вивід зубчатого масиву myArray:");
            for(int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Створення зубчатого масиву myArray2 та заповнення його рандомними числами");

            int[][] myArray2 = new int[3][];

            Random random = new Random();

            for (int i = 0; i < myArray2.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Введiть кількість елементів для рядка {i} масиву myArray2:");
                    int length = int.TryParse(Console.ReadLine(), out length) ? length : throw new FormatException();
                    myArray2[i] = new int[length];
                }
                catch (FormatException)// Цей блок catch обробляє помилки, які виникають, коли введене значення не може бути перетворено в ціле число. Якщо користувач введе текст або інші символи, які не є числами, буде згенеровано виключення FormatException.
                {
                    Console.WriteLine("Помилка: введено не число. Встановлено довжину рядка за замовчуванням (5).");
                    myArray2[i] = new int[5];
                }
                catch (OverflowException)// Цей блок catch обробляє помилки, які виникають, коли введене число занадто велике або занадто маленьке для типу int. Якщо користувач введе число, яке виходить за межі допустимого діапазону для типу int, буде згенеровано виключення OverflowException.
                {
                    Console.WriteLine("Помилка: введене число занадто велике або занадто маленьке. Встановлено довжину рядка за замовчуванням (5).");
                    myArray2[i] = new int[5];
                }
                for (int j = 0; j < myArray2[i].Length; j++)
                {
                    myArray2[i][j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Вивід зубчатого масиву myArray2:");
            for(int i = 0; i < myArray2.Length; i++)
            {
                for (int j = 0; j < myArray2[i].Length; j++)
                {
                    Console.Write(myArray2[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
