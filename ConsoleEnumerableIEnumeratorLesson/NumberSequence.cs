using System.Collections;
using System.Collections.Generic;

namespace ConsoleEnumerableIEnumeratorLesson
{
    internal class NumberSequence : IEnumerable<int>
    {
        private readonly int _start;
        private readonly int _count;
       

        public NumberSequence(int start, int count)
        {
            _start = start;
            _count = count;

        }

        public IEnumerator<int> GetEnumerator() // Реалізація IEnumerable<int>
        {
            return new NumberEnumerator(_start, _count);
        }
        IEnumerator IEnumerable.GetEnumerator() // Реалізація базового IEnumerable 
        {
            return GetEnumerator();
        }
    }
}
