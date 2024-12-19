using System;

namespace _7_laba_suh
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new ArrayProcessor();

            try
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                string input = Console.ReadLine(); // Чтение ввода от пользователя
                int[] array = Array.ConvertAll(input.Split(' '), int.Parse); // Преобразование строки в массив чисел

                Console.WriteLine("Сортировка массива:");
                int[] sortedArray = processor.SortArray(array);
                Console.WriteLine(string.Join(" ", sortedArray)); // Вывод отсортированного массива

                Console.WriteLine("Максимальное значение:");
                Console.WriteLine(processor.FindMax(array)); // Вывод максимального значения

                Console.WriteLine("Среднее значение:");
                Console.WriteLine(processor.CalculateAverage(array)); // Вывод среднего значения

                Console.WriteLine("Медиана:");
                Console.WriteLine(processor.FindMedian(array)); // Вывод медианы

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}"); // Обработка ошибок
            }
        }
    }
}
