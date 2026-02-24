namespace ConsoleArrayLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };

            int[] myArray1 = Enumerable.Range(4, 5).ToArray();// [4, 5, 6, 7, 8] заповнення масиву послідовними числами від 4 до 8
                                                              // Enumerable - це клас, який містить статичні методи для роботи з колекціями даних, такими як масиви,
                                                              // списки та інші типи колекцій. Метод Range генерує послідовність цілих чисел, починаючи з вказаного значення (4)
                                                              // і має вказану кількість елементів (5). Метод ToArray() перетворює отриману послідовність у масив.

            int[] myArray2 = Enumerable.Repeat(10, 5).ToArray(); // [10, 10, 10, 10, 10] заповнення масиву з 5 елементів числом 10
                                                                 // Метод Repeat генерує послідовність, яка повторює вказане значення (10) певну кількість разів (5). 
                                                                 // Метод ToArray() перетворює отриману послідовність у масив.

            Console.WriteLine(string.Join(", ", myArray));//join - це метод, який об'єднує елементи масиву в рядок,
                                                          //використовуючи вказаний роздільник (у цьому випадку ", ").
            Console.WriteLine(string.Join(", ", myArray1));
            Console.WriteLine(string.Join(", ", myArray2));

            for (int i = 0; i < myArray.Length; i++)//myArray.Length - це властивість, яка повертає кількість елементів у масиві myArray.
            {
                Console.WriteLine($"Елемент з iндексом {i} має значення {myArray[i]}");
            }

            //---------------------------------------------------------------
            uint length = 0;
            Console.WriteLine("Завдання 1. Заповнити масив заданої довжини з клавiатури та вивести його на екран:");
            Console.WriteLine("Введiть довжину масиву:");

            try
            {
                length = uint.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Помилка: Введiть коректне цiле число.");
                Console.ReadLine();
                return;    
            }
           
            uint [] userArray = new uint[length];

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Введiть елемент з iндексом {i}:");
                try
                {
                    uint element = uint.Parse(Console.ReadLine());
                    userArray[i] = element;
                    Console.WriteLine($"Елемент з iндексом {i} має значення {userArray[i]}");

                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка: Введiть коректне цiле число.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Виведення масиву на екран:");

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Елемент з iндексом {i} має значення {userArray[i]}");
            }

            //---------------------------------------------------------------

            Console.WriteLine("Завдання 2. Вивести масив в оберненому порядку:");
            Console.WriteLine("Використання масиву з завдання 1:");

            for(int i = userArray.Length - 1; i >= 0; i--)
            {
                    Console.WriteLine($"Елемент з iндексом {i} має значення {userArray[i]}");
            }

            //---------------------------------------------------------------

            Console.WriteLine("Завдання 3. Знайти суму всiх парних елементiв масиву:");
            Console.WriteLine("Використаємо масив на 10 елементiв, заповнений рандомними числами вiд 1 до 100:");

            int[] randomArray = new int[10];

            Random random = new Random();//Random - це клас, який використовується для генерації випадкових чисел.
                                         //Він надає методи для створення випадкових чисел різних типів, таких як цілі числа,
                                         //дійсні числа та інші.

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 101);//random.Next(1, 101) - це метод, який генерує випадкове ціле число в діапазоні від 1 до 100 (включно).
            }
            Console.WriteLine("Згенерований масив:");
            Console.WriteLine(string.Join(", ", randomArray));//Виведення згенерованого масиву на екран.
           
            int sumEven = 0;
            
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)//Перевірка, чи є елемент парним (ділення на 2 без остачі).
                {
                    sumEven += randomArray[i];//Якщо елемент парний, додаємо його до суми.
                }
            }

            Console.WriteLine("Сума всiх парних елементiв масиву:" + sumEven);

            //--------------------------------------------------------------------------------
             Console.WriteLine("Завдання 4. Знайти максимальний та мiнiмальний елемент масиву:");
             Console.WriteLine("Використаємо масив з завдання 3:");
             Console.WriteLine("Згенерований масив:");
             Console.WriteLine(string.Join(", ", randomArray));

            int maxElement = randomArray[0];
            int minElement = randomArray[0];

            Console.WriteLine("Знаходимо максимальний та мiнiмальний елемент масиву:");
            
            for(int i = 0; i < randomArray.Length; i++)
            {
                if(randomArray[i] > maxElement)
                {
                    maxElement = randomArray[i];
                }
                if(randomArray[i] < minElement)
                {
                    minElement = randomArray[i];
                }
            }
            Console.WriteLine("Максимальний елемент масиву: " + maxElement);
            Console.WriteLine("Мiнiмальний елемент масиву: " + minElement);

        }
    }
}
