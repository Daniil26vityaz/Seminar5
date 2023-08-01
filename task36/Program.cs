namespace task36;

class Program
{
    static void Main(string[] args)
    {
        //=========== Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

        // [3, 7, 23, 12] -> 19
        // [-4, -6, 89, 6] -> 0


        Random rnd = new Random();
        int size = 10;
        int[] array = new int[size];
        int sum = 0;
        Console.Write($"Заданный массив:  ");
        for (int i = 0; i <= size; i++)
        {
            array[i] = rnd.Next();
            Console.Write($"{array[i]} ");
        }
        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 == 1)
            {
                Console.WriteLine($"{array[i]} - отрицательный член массива ");
                sum += array[i];
            }

            Console.WriteLine($"Сумма отрицательных членов заданного массива = {sum} ");

        }
    }
}
