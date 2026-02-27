using System.Linq;

namespace ConsoleArray3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення тривимірного масиву myArray3D з розмірами 3x4x5 та заповнення його рандомними числами. 
            int[,,] myArray3D = new int[3, 4, 5];

            Random random = new Random();

            for (int i = 0; i < myArray3D.GetLength(0); i++)//Заповнюємо тривимірний масив рандомними числами.
            {
                for (int j = 0; j < myArray3D.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray3D.GetLength(2); k++)
                    {
                        myArray3D[i, j, k] = random.Next(1, 100);
                    }
                }
            }

            Console.WriteLine("Елементи тривимірного масиву myArray3D:");
            for (int i = 0; i < myArray3D.GetLength(0); i++)
            {
                Console.WriteLine($"Рівень {i}:");
                for (int j = 0; j < myArray3D.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray3D.GetLength(2); k++)
                    {
                        Console.Write(myArray3D[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------------");
            // Створення зубчатого тривимірного масиву myArray3D2 з рандомими розмірами, та заповнення його рандомними числами.

            int[][][] myArray3DRandom = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray3DRandom.Length; i++)
            {
                myArray3DRandom[i] = new int[random.Next(1, 5)][];
                for (int j = 0; j < myArray3DRandom[i].Length; j++)
                {
                    myArray3DRandom[i][j] = new int[random.Next(2, 10)];
                    for (int k = 0; k < myArray3DRandom[i][j].Length; k++)
                    {
                        myArray3DRandom[i][j][k] = random.Next(1, 100);
                    }
                }
            }

            Console.WriteLine("Елементи зубчатого тривимірного масиву myArray3DRandom:");

            for (int i = 0; i < myArray3DRandom.Length; i++)
            {
                Console.WriteLine($"Рівень {i}:");
                for (int j = 0; j < myArray3DRandom[i].Length; j++)
                {
                    for (int k = 0; k < myArray3DRandom[i][j].Length; k++)
                    {
                        Console.Write(myArray3DRandom[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }
    }
}
