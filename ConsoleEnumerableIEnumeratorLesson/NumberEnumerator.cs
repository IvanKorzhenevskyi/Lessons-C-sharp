using System.Collections;
using System.Collections.Generic;

namespace ConsoleEnumerableIEnumeratorLesson
{
    internal class NumberEnumerator : IEnumerator<int>
    {
        private readonly int _start;
        private readonly int _count;
        private const int MIN_VALUE = -1; // константа для зручності читання в коді.
        private int _currentIndex;

        public NumberEnumerator(int start, int count) // базовий конструктор класу NumberEnumerator
        {
            _start = start;
            _count = count;
            _currentIndex = MIN_VALUE;
        }

        public int Current // Реалізація контрактку інтерфейсу IEnumerator<int>
        {
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _count)
                {
                    throw new InvalidOperationException("Enumarator is in an invalid state.");
                }
                return _start + _currentIndex;
            }
        }

        object IEnumerator.Current => Current; // Реалізовуємо контракт базового інтерфесу без generics IEnumerator
        public bool MoveNext()
        {
            if (_currentIndex < _count - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Dispose() // Метод очистки
        {
            // No resources to dispose
        }

        public void Reset() // Метод встановлення початкової позиції
        {
            _currentIndex = MIN_VALUE;
        }

    }
}

