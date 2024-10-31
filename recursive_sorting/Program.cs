using System;

namespace recursive_sorting
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var numbersArray = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(parts[i]);
            }

             
            numbersArray = QuickSort(numbersArray, 0, numbersArray.Length - 1);
            Console.WriteLine("Отсортированный массив: " + string.Join(" ", numbersArray));
            Console.ReadKey();
        }

        static int[] QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
            return array;
        }

        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            int tamp = 0;
            for (int j = left; j <= right - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    tamp = array[i];
                    array[i] = array[j];
                    array[j] = tamp;
                }
            }
            tamp = array[i + 1];
            array[i + 1] = array[right];
            array[right] = tamp;
            return i + 1;
        }
    }
}
