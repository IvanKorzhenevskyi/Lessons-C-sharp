/*
 * 1.Написати метод,який вивлде на екран рядок, символи якого і їх кількість вводить користувач.
 * 
 * 2. Написати метод для пошука індексу елемента в масиві( тип елемента int). 
 *    Метод має повернути індекс першого знайденого елемента(якщо він є в масиві) або повідомити про те що він відсутній.
 * 
 */

namespace ConsoleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1: Виведення рядка з символів та їх кількості, які вводить користувач.");

            char userInputSymbol;
            int userInputCount;
            bool isValidInput = false;

            Console.WriteLine("Введiть символ, який хочете вивести на екран:");
            userInputSymbol = char.TryParse(Console.ReadLine(), out userInputSymbol) ? userInputSymbol : userInputSymbol = '*'; // Якщо введено не символ, встановлюємо символ за замовчуванням '*'.

            Console.WriteLine("Введiть кількість разів, скільки разів хочете вивести цей символ:");
            do
            {
                try
                {
                    userInputCount = int.TryParse(Console.ReadLine(), out userInputCount) ? userInputCount : throw new FormatException();

                    PrintSymbols(userInputSymbol, userInputCount);
                    isValidInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: введено не число. Спробуйте ще раз.");
                    isValidInput = true;
                }
            } while (isValidInput);

            //--------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nЗавдання 2: Пошук індексу елемента в масиві типу int.");

            int[] myArray = new int[10];
            int userInputElement;
            isValidInput = false;

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 100);
            }
            Console.WriteLine("Згенерований масив з рандомними числами на 10 елементів:");

            // Імітація тривалої операції, яка займає час (наприклад, генерація великого масиву або складні обчислення).З лічильником для відображення прогресу.
            int counter = 10;
            Console.WriteLine("Генерація масиву...");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(counter + "% ");
                System.Threading.Thread.Sleep(200); // Затримка для імітації тривалої операції
                counter += 10;
            }
            Console.WriteLine("\nМасив згенеровано!");

            Console.WriteLine("\nВведiть число, індекс якого хочете знайти в масиві:");
            do
            {             
                try
                {
                    userInputElement = int.TryParse(Console.ReadLine(), out userInputElement) ? userInputElement : throw new FormatException();

                    FindElementIndex(myArray, userInputElement);
                    isValidInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: введено не число. Спробуйте ще раз.");
                    isValidInput = true;
                }
            } while (isValidInput);

            Console.WriteLine("Згенерований масив:");
            foreach (int num in myArray)
            {
                Console.Write(num + " ");
            }

            static void PrintSymbols(char symbol, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            static void FindElementIndex(int[] array, int element)
            {
                int index = Array.IndexOf(array, element);
                if (index != -1)
                {
                    Console.WriteLine($"Елемент {element} знайдено в масиві на індексі: {index}");
                }
                else
                {
                    Console.WriteLine($"Елемент {element} відсутній в масиві.");
                }
            }
        }
    }
}
