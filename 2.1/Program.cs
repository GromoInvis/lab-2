using System;

class Program
{
    static void Main()
    {
        double[] array = { 1.5, -2.7, 3.0, 0.0, -4.2, 5.1, 6.3, -7.0, 8.9 };

        // Задання 1
        double minElement = FindMinElement(array);
        Console.WriteLine($"Мінімальний елемент масиву: {minElement}");

        double sumBetweenPositives = SumBetweenPositives(array);
        Console.WriteLine($"Сума елементів між першим і останнім додатніми: {sumBetweenPositives}");

        // Перетворення масиву
        TransformArray(array);
        Console.WriteLine("Масив після перетворення:");
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
    }

    static double FindMinElement(double[] array)
    {
        double min = array[0];
        foreach (var element in array)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }

    static double SumBetweenPositives(double[] array)
    {
        bool foundFirstPositive = false;
        double sum = 0;

        foreach (var element in array)
        {
            if (element > 0)
            {
                if (foundFirstPositive)
                {
                    break;
                }
                foundFirstPositive = true;
            }
            else if (foundFirstPositive)
            {
                sum += element;
            }
        }

        return sum;
    }

    static void TransformArray(double[] array)
    {
        // Сортування елементів, рівних нулю, на початку
        Array.Sort(array, (x, y) => x == 0 ? -1 : y == 0 ? 1 : 0);
    }
}