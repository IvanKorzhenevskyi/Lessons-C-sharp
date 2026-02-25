using System.Linq;

namespace ConsoleArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray2 = new int[,]
          {
                {1, 2, 3, 4 ,45},
                {4, 5, 6, 18, 5},
                {7, 8, 9, 76, 52}
          };

            Console.WriteLine("Елементи двовимірного масиву myArray2:");
            foreach (int element in myArray2) // Цикл foreach - це цикл, який перебирає кожен элемент в колекції myArray2. В цьому випадку, кожен элемент присвоюється змінній element,
                                              // і тіло циклу виконується для кожного элемента.
            {
                Console.Write(element + " "); // Виводить поточний элемент на екран.
            }

            int height = myArray2.GetLength(1); // Метод GetLength - це метод, який повертає довжину виміру масиву. У цьому випадку, myArray2.GetLength(1) поверне кількість стовпців у двовимірному масиві myArray2.
            int width = myArray2.GetLength(0); // Метод GetLength - це метод, який повертає довжину виміру масиву. У цьому випадку, myArray2.GetLength(0) поверне кількість рядків у двовимірному масиві myArray2.

            Console.WriteLine("\nЕлементи двовимірного масиву myArray2 у вигляді таблиці:");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray2[x, y] + "\t"); // Виводить елемент з координатами (x, y) на екран.
                }
                Console.WriteLine(); // Виводить новий рядок після кожного рядка елементів.
            }
            //--------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Стврюємо двовимірний масив myArray3 з розмірами, які вводить користувач:");

            Console.WriteLine("Введiть кількість рядків для масиву myArray3:");
            int rowsArray3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кількість стовпців для масиву myArray3:");
            int columnsArray3 = int.Parse(Console.ReadLine());

            int[,] myArray3 = new int[rowsArray3, columnsArray3];

            Console.WriteLine("Заповніть масив myArray3:");

            for (int i = 0; i < rowsArray3; i++)
            {
                for (int j = 0; j < columnsArray3; j++)
                {
                    Console.WriteLine($"Введiть елемент з координатами ({i}, {j}):");
                    myArray3[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Елементи двовимірного масиву myArray3 у вигляді таблиці:");
            for (int y = 0; y < columnsArray3; y++)
            {
                for (int x = 0; x < rowsArray3; x++)
                {
                    Console.Write(myArray3[x, y] + "\t");
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Створимо масив myArray4, з розмірами, які вводить користувач, але заповнений рандомними числами:");

            Console.WriteLine("Введiть кількість рядків для масиву myArray4:");
            int rowsArray4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кількість стовпців для масиву myArray4:");
            int columnsArray4 = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[,] myArray4 = new int[rowsArray4, columnsArray4];

            for (int i = 0; i < rowsArray4; i++)
            {
                for(int j =0; j < columnsArray4; j++)
                {
                    myArray4[i, j] = random.Next(1, 100); // Заповнює масив myArray4 випадковими числами від 1 до 99.
                }
            }
            Console.WriteLine("Елементи двовимірного масиву myArray4 у вигляді таблиці:");
            for (int y = 0; y < columnsArray4; y++)
            {
                for (int x = 0; x < rowsArray4; x++)
                {
                    Console.Write(myArray4[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Найбільше та найменше значення в масиві myArray4:");
            Console.WriteLine(myArray4.Cast<int>().Max()); // Метод Cast - це метод, який перетворює елементи масиву myArray4 у тип int.
                                                           // Метод Max - це метод, який повертає найбільше значення серед елементів масиву myArray4.
            Console.WriteLine(myArray4.Cast<int>().Min()); // Min - це метод, який повертає найменше значення серед елементів масиву myArray4.

            Console.WriteLine("Парні числа в масиві myArray4:");
            Console.WriteLine(myArray4.Cast<int>().Where(x => x % 2 == 0).Count()); // Метод Where - це метод, який фільтрує елементи колекції на основі заданої умови (у цьому випадку, де x % 2 == 0 означає, що елемент є парним).
                                                                                    // Метод Count - це метод, який повертає кількість елементів в колекції, що відповідають умові.
            Console.WriteLine("Непарні числа в масиві myArray4:");
            Console.WriteLine(myArray4.Cast<int>().Where(x => x % 2 != 0).Count()); // Метод Where - це метод, який фільтрує елементи колекції на основі заданої умови (у цьому випадку, де x % 2 != 0 означає, що елемент є непарним).
                                                                                    // Метод Count - це метод, який повертає кількість елементів в колекції, що відповідають умові.
            Console.WriteLine("Сума всіх елементів в масиві myArray4:");
            Console.WriteLine(myArray4.Cast<int>().Sum()); // Метод Sum - це метод, який повертає суму всіх елементів в масиві myArray4.

            Console.ReadLine();
        }
    }
}
