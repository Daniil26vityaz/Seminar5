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
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(1, 10);
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine($"{array[i]} - отрицательный индекс у данного члена массива {i}");
                sum += array[i];
            }


        }
        Console.WriteLine($"Сумма членов заданного массива с отрицательным индексом = {sum} ");

    }
}
