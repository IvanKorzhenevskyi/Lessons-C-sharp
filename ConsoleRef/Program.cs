using System.Linq;

/*
 * 1. Написати метод Resize, який змiнює кiлькiсть елементiв у масивi(збiльшити або зменшити розмiр) та вивести його на екран.
 * 2. Написати методи для додавання елементiв в кiнець, початок та обрану позицiю по iндексу масиву та вивести його на екран.
 * 3. Написати методи для видалення елементiв з кiнця, початку та обраної позицiї по iндексу масиву та вивести його на екран.
 */

namespace ConsoleRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidinput;

            Random random = new Random();

            int[] arr = new int[10].Select(x => random.Next(1, 100)).ToArray(); // Створюємо масив з 10 випадкових чисел вiд 1 до 100

            Console.WriteLine("Початковий масив:");

            foreach (var item in arr)// Виводимо масив на екран
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nЗмiна розмiру масиву.");
            int newSize;
            do
            {
                Console.WriteLine("Введiть новий розмiр масиву:");
                string? inputSizeArray = Console.ReadLine();
                if (!int.TryParse(inputSizeArray, out newSize) || newSize < 0)
                {
                    Console.WriteLine("Масив не може мати вiд'ємний розмiр або бути не числом. Спробуйте ще раз.");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                    Resize(ref arr, newSize);
                }

            } while (!isValidinput);// Перевiряємо, чи введений розмiр є дiйсним числом та не є вiд'ємним. Якщо введення некоректне, просимо користувача ввести розмiр ще раз.

            Console.WriteLine("Масив пiсля змiни розмiру:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nДодавання елемента в кiнець масиву:");
            int newElementEnd;

            do
            {
                Console.WriteLine("Введiть елемент для додавання в кiнець масиву:");
                string? inputElementEnd = Console.ReadLine();
                if (!int.TryParse(inputElementEnd, out newElementEnd))
                {
                    Console.WriteLine("Введений елемент не є числом. Спробуйте ще раз.");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                    AddToEnd(ref arr, newElementEnd);
                }


            } while (!isValidinput);// Перевiрка i додавання елемента в кiнець масиву

            Console.WriteLine("Масив пiсля додавання елемента в кiнець:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nДодавання елемента в початок масиву:");
            int newElementStart;
            do
            {

                Console.WriteLine("Введiть елемент для додавання в початок масиву:");
                string? inputElementStart = Console.ReadLine();
                if (!int.TryParse(inputElementStart, out newElementStart))
                {
                    Console.WriteLine("Введений елемент не є числом. Спробуйте ще раз.");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                    AddToStart(ref arr, newElementStart);
                }

            } while (!isValidinput); // Перевiрка i додавання елемента в початок масиву

            Console.WriteLine("Масив пiсля додавання елемента в початок:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nДодавання елемента в обрану позицiю по iндексу:");
            int newElementPosition;
            int indexPosition;

            do
            {
                Console.WriteLine("Введiть число для додавання в обрану позицiю масиву:");
                string? inputElementPosition = Console.ReadLine();
                if (!int.TryParse(inputElementPosition, out newElementPosition))
                {
                    Console.WriteLine("Введений елемент не є числом. Спробуйте ще раз.");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                }

            } while (!isValidinput);

            do
            {
                Console.WriteLine("Введiть iндекс для додавання елемента в обрану позицiю масиву:");
                string? inputindexPosition = Console.ReadLine();
                if (!int.TryParse(inputindexPosition, out indexPosition) || indexPosition < 0 || indexPosition > arr.Length)
                {
                    Console.WriteLine("Введений iндекс не є числом або поза межами масиву. Спробуйте ще раз.");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                }

            } while (!isValidinput);

            AddAtPosition(ref arr, newElementPosition, indexPosition);

            Console.WriteLine("Масив пiсля додавання елемента в обрану позицiю:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nВидалення останнього елемента масиву");
            RemoveFromEnd(ref arr);
            Console.WriteLine("Вивiд масиву пiсля видалення: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nВидалення першого елемента масиву");
            RemoveFromStart(ref arr);
            Console.WriteLine("Вивiд масиву пiсля видалення: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //-----------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nВидалення елементу масиву на обранiй позицiї");
            int setRemovePosition;
            do
            {
                Console.WriteLine("Введiть позицiю в масивi:");
                string? inputRemovePosition = Console.ReadLine();
                if(!int.TryParse(inputRemovePosition, out setRemovePosition))
                {
                    Console.WriteLine("Не вiрно введене значення. Введiть число ( 1-й iндекс масиву починається з 0).");
                    isValidinput = false;
                }
                else
                {
                    isValidinput = true;
                    RemoveAtPosition(ref arr, setRemovePosition);
                }

            } while (!isValidinput);
            Console.WriteLine("Вивiд масиву пiсля видалення обраного елементу:");
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }


        static void Resize(ref int[] arr, int newSize)// Метод Resize змiнює розмiр масиву, приймаючи його за посиланням та новий розмiр як параметри
        {
            // Створюємо новий масив з новим розмiром та заповнюємо новi елементи рандомними числами вiд 1 до 100, якщо новий розмiр бiльший за поточний
            int[] newArr = new int[newSize];
            for (int i = 0; i < newSize; i++)
            {
                if (i < arr.Length) // Якщо iндекс менший за поточний розмiр, копiюємо iснуючi елементи
                {
                    newArr[i] = arr[i]; // Копiюємо iснуючi елементи
                }
                else // Якщо iндекс бiльший або рiвний поточному розмiру, заповнюємо новi елементи випадковими числами
                {
                    newArr[i] = new Random().Next(1, 100); // Заповнюємо новi елементи випадковими числами
                }
            }
            arr = newArr; // Замiнюємо старий масив на новий
        }

        static void AddToEnd(ref int[] arr, int newElement) // Метод для додавання елемента в кiнець масиву
        {
            Resize(ref arr, arr.Length + 1); // Збiльшуємо розмiр масиву на 1
            arr[arr.Length - 1] = newElement; // Додаємо новий елемент в кiнець масиву
        }

        static void AddToStart(ref int[] arr, int newElement) // Метод для додавання елемента в початок масиву
        {
            Resize(ref arr, arr.Length + 1); // Збiльшуємо розмiр масиву на 1
            for (int i = arr.Length - 1; i > 0; i--) // Зсуваємо всi елементи на одну позицiю вправо
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = newElement; // Додаємо новий елемент в початок масиву
        }

        static void AddAtPosition(ref int[] arr, int newElement, int index) // Метод для додавання елемента в обрану позицiю по iндексу
        {
            if (index < 0 || index > arr.Length) // Перевiряємо, чи iндекс в межах допустимого дiапазону
            {
                Console.WriteLine("iндекс поза межами масиву. Спробуйте ще раз.");
                return;
            }
            Resize(ref arr, arr.Length + 1); // Збiльшуємо розмiр масиву на 1
            for (int i = arr.Length - 1; i > index; i--) // Зсуваємо всi елементи на одну позицiю вправо, починаючи з кiнця до iндексу
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = newElement; // Додаємо новий елемент в обрану позицiю
        }

        static void RemoveFromEnd(ref int[] arr) // Метод для видалення елемента з кiнця масиву
        {
            if (arr.Length == 0) // Перевiряємо, чи масив не порожнiй
            {
                Console.WriteLine("Масив вже порожнiй. Немає елементiв для видалення.");
                return;
            }
            Resize(ref arr, arr.Length - 1); // Зменшуємо розмiр масиву на 1
        }

        static void RemoveFromStart(ref int[] arr) // Метод для видалення елемента з початку масиву
        {
            if (arr.Length == 0) // Перевiряємо, чи масив не порожнiй
            {
                Console.WriteLine("Масив вже порожнiй. Немає елементiв для видалення.");
                return;
            }
            for (int i = 0; i < arr.Length - 1; i++) // Зсуваємо всi елементи на одну позицiю влiво, починаючи з початку до кiнця
            {
                arr[i] = arr[i + 1];
            }
            Resize(ref arr, arr.Length - 1); // Зменшуємо розмiр масиву на 1
        }

        static void RemoveAtPosition(ref int[] arr, int index) // Метод для видалення елемента з обраної позицiї по iндексу
        {
            if (index < 0 || index >= arr.Length) // Перевiряємо, чи iндекс в межах допустимого дiапазону
            {
                Console.WriteLine("iндекс поза межами масиву. Спробуйте ще раз.");
                return;
            }
            for (int i = index; i < arr.Length - 1; i++) // Зсуваємо всi елементи на одну позицiю влiво, починаючи з iндексу до кiнця
            {
                arr[i] = arr[i + 1];
            }
            Resize(ref arr, arr.Length - 1); // Зменшуємо розмiр масиву на 1
        }
    }
}
