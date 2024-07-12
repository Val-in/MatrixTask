using System.Diagnostics;

namespace MatrixTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int element = 10;
            int result = GetIndex(array, element);
            Console.WriteLine(result);
        }

        static int GetIndex(int[] array, int element)
        {
            int index;
            // Проходим по всем элементам массива
            for (index = 0; index < array.Length; index++)
            {
                // Если текущий элемент массива больше вставляемого числа
                if (array[index] > element)
                    return index; // Возвращаем текущий индекс
            }
            // Если все элементы массива меньше вставляемого числа, возвращаем индекс за последним элементом
            return index;
        }
    }
}
