namespace task38;

class Program
{
    static void Main(string[] args)
    {
        //============== Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

        // [3,21 7,04 22,93 -2,71 78,24] -> 80,95


        Random rnd = new Random();
        int size = 10;
        double[] array = new double[size];
        double min = array[0];
        double max = 0;
        Console.Write($"Заданный массив:  ");
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(10, 100) + rnd.NextDouble();
            Console.Write($"{Math.Round(array[i],2)} || ");
        }
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            if (array[i] > max)
            {
                max = Math.Round(array[i],2);

            }

        }
        Console.Write($"{max} - maximal number ");
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {

            if (array[i] < max)
            {
                min = Math.Round(array[i],2);

            }

        }
        Console.Write($"{min} - manimal number ");
        Console.WriteLine();
        Console.Write($"{max} - {min} = {Math.Round((max - min),2)} ");
    }
}
