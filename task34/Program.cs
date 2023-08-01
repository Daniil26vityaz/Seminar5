namespace task34;

class Program
{
    static void Main(string[] args)
    {
        //===========Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        // Напишите программу, которая покажет количество чётных чисел в массиве.

        // [345, 897, 568, 234] -> 2

        Random rnd = new Random();
        int size = 10;
        int count = 0;
        int[] array = new int[size];
        Console.Write($"Заданный массив:  ");
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(100, 1000);
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine($"{array[i]} - положительный член массива ");
                count ++;
            }
            
        }Console.WriteLine($"Количество положительных членов заданного массива = {count} ");
        Console.WriteLine();
    }
}
