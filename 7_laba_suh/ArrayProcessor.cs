using System;
using System.Linq;

namespace _7_laba_suh
{
    public class ArrayProcessor
    {
        public int[] SortArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Массив не может быть null");

            Array.Sort(array);
            return array;
        }

        public int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null");

            return array.Max();
        }

        public double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null");

            return array.Average();
        }

        public double FindMedian(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null");

            var sortedArray = SortArray(array);
            int mid = sortedArray.Length / 2;

            if (sortedArray.Length % 2 == 0)
                return (sortedArray[mid - 1] + sortedArray[mid]) / 2.0;

            return sortedArray[mid];
        }
    }
}