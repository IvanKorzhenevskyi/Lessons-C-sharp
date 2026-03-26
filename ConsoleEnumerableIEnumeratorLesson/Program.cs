
namespace ConsoleEnumerableIEnumeratorLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> sequence = new NumberSequence(start: 1, count : 10);

            foreach (var number in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
