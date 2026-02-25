
using System.Linq; // Директива using System.Linq дозволяє використовувати методи розширення LINQ, такі як Select, Max, Min тощо.

namespace ConsoleArrayLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            Random random = new Random();

            myArray = myArray.Select(x => random.Next(1, 100)).ToArray();// Метод Select - це метод розширення LINQ,
                                                                         // який застосовує задану функцію до кожного
                                                                         // елемента колекції та повертає нову колекцію з результатами.
            Console.WriteLine("Згенерований масив myArray:");
            Console.WriteLine(string.Join(", ", myArray)); // Join - це метод, який об'єднує елементи масиву в рядок, використовуючи вказаний
                                                           // роздільник (у цьому випадку ", ").

            Console.WriteLine("Сума всіх елементів в масиві myArray");
            Console.WriteLine(myArray.Sum()); // Метод Sum - це метод, який повертає суму всіх елементів в масиві myArray.

            Console.WriteLine("Середнє значення елементів в масиві myArray");
            Console.WriteLine(myArray.Average()); // Метод Average - це метод, який повертає середнє значення елементів в масиві myArray.

            Console.WriteLine("Максимальне та мінімальне значення в масиві myArray");
            Console.WriteLine(myArray.Max()); // Метод Max - це метод, який повертає максимальне значення в масиві myArray.
            Console.WriteLine(myArray.Min()); // Метод Min - це метод, який повертає мінімальне значення в масиві myArray.

            Console.WriteLine(myArray.Where(x => x % 2 == 0).Count()); // Метод Where - це метод, який фільтрує елементи колекції
                                                                       // на основі заданої умови (у цьому випадку, де x % 2 == 0 означає,
                                                                       // що елемент є парним). Метод Count - це метод, який повертає
                                                                       // кількість елементів в колекції, що відповідають умові.

            Console.WriteLine(myArray.Where(x => x % 2 != 0).Count()); // Метод Where - це метод, який фільтрує елементи колекції
                                                                       // на основі заданої умови (у цьому випадку, де x % 2 != 0 означає,
                                                                       // що елемент є непарним). Метод Count - це метод, який повертає
                                                                       // кількість елементів в колекції, що відповідають умові.

            Console.WriteLine("Відсортований масив myArray за зростанням:");
            Console.WriteLine(myArray.OrderBy(x => x).ToArray()); // Метод OrderBy - це метод, який сортує елементи колекції за зростанням
                                                                  // на основі заданого ключа (у цьому випадку, x => x означає, що елементи
                                                                  // сортуються за їх власними значеннями). Метод ToArray() перетворює
                                                                  // відсортовану колекцію у масив.

            Console.WriteLine("Відсортований масив myArray за спаданням:");
            Console.WriteLine(myArray.OrderByDescending(x => x).ToArray()); // Метод OrderByDescending - це метод, який сортує елементи колекції
                                                                            // за спаданням на основі заданого ключа (у цьому випадку,
                                                                            // x => x означає, що елементи
                                                                            // сортуються за їх власними значеннями). Метод ToArray() перетворює
                                                                            // відсортовану колекцію у масив.

            Console.WriteLine("Кількість елементів в масиві myArray:");
            Console.WriteLine(myArray.Length); // Властивість Length - це властивість, яка повертає кількість елементів в масиві myArray.

            Console.WriteLine("Унікальні елементи в масиві myArray:");
            Console.WriteLine(myArray.Distinct().ToArray()); // Метод Distinct - це метод, який повертає унікальні елементи з колекції myArray.
                                                             // Метод ToArray() перетворює результат у масив.

            Console.WriteLine("Групування елементів в масиві myArray за парністю:");
            Console.WriteLine(myArray.GroupBy(x => x % 2 == 0).Select(g => new { Key = g.Key, Count = g.Count() }).ToArray()); // Метод GroupBy - це метод,
            // який групує елементи колекції на основі заданого ключа (у цьому випадку, x => x % 2 == 0 означає, що елементи групуються за парністю).
            // Метод Select - це метод, який проєктує кожну групу в новий анонімний тип, який містить ключ групи (Key) та кількість елементів у групі (Count).
            // Метод ToArray() перетворює результат у масив.

            Console.WriteLine("Перші 3 елементи в масиві myArray:");
            Console.WriteLine(myArray.Take(3).ToArray()); // Метод Take - це метод, який повертає перші n елементів з колекції myArray (у цьому випадку, 3).
                                                          // Метод ToArray() перетворює результат у масив.

            Console.WriteLine("Останні 3 елементи в масиві myArray:");
            Console.WriteLine(myArray.Skip(myArray.Length - 3).ToArray()); // Метод Skip - це метод, який пропускає перші n елементів з
                                                                           // колекції myArray (у цьому випадку, myArray.Length - 3 означає, що пропускаються
                                                                           // всі елементи, крім останніх 3).
                                                                           // Метод ToArray() перетворює результат у масив.

            Console.WriteLine("Елементи в масиві myArray, які більші за 50:");
            Console.WriteLine(myArray.Where(x => x > 50).ToArray()); // Метод Where - це метод, який фільтрує елементи колекції на основі заданої умови
                                                                     // (у цьому випадку, x > 50 означає, що елементи вибираються, якщо вони більші за 50).
                                                                     // Метод ToArray() перетворює результат у масив.

            Console.WriteLine("Елементи в масиві myArray, множаться на 2:");
            Console.WriteLine(myArray.Select(x => x * 2).ToArray()); // Метод Select - це метод, який застосовує задану функцію до кожного элемента колекції
                                                                     // (у цьому випадку, x => x * 2 означає, що кожен элемент множиться на 2). Метод ToArray()
                                                                     // перетворює результат у масив.

            myArray.Equals(myArray); // Метод Equals - це метод, який порівнює два об'єкти на рівність. У цьому випадку, myArray.Equals(myArray) поверне true,
                                     // оскільки ми порівнюємо масив з самим собою.

            Console.WriteLine("Виведення елементів масиву myArray за допомогою методу ForEach:");
            myArray.ToList().ForEach(x => Console.WriteLine(x)); // Метод ToList() перетворює масив myArray у список, а метод ForEach()
                                                                 // виконує задану дію для кожного елемента списку (у цьому випадку,
                                                                 // Console.WriteLine(x) виводить кожен элемент на екран).

            Console.WriteLine("Виведення елементів масиву myArray за допомогою циклу foreach:");
            foreach (int element in myArray) // Цикл foreach - це цикл, який перебирає кожен элемент в колекції myArray. В цьому випадку, кожен элемент присвоюється змінній element,
                                             // і тіло циклу виконується для кожного элемента.
            {
                Console.WriteLine(element); // Виводить поточний элемент на екран.
            }


        }
    }
}
