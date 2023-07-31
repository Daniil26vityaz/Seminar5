namespace task34;

class Program
{
    static void Main(string[] args)
    {
        //===========Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        // Напишите программу, которая покажет количество чётных чисел в массиве.

        // [345, 897, 568, 234] -> 2

        int n = new Random().Next(100, 1000);
        int[] array = new int[10];
        for (int j = 0; j <= array.Length; j++)
        {
            array[j]=n;
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i] > 100 || array[i] < 1000)
                {
                    if (array[i] % 2 == 0)
                    {
                        Console.WriteLine($"{i} = {array[i]}");
                    }
                }
            }
        }






    }
}
