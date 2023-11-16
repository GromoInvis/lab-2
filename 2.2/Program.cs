using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, -3, -4 },
            { -5, 6, 7, -8 },
            { 9, 10, 11, 12 }
        };

        // Задання 2
        int sumColumnsWithNegative = SumColumnsWithNegative(matrix);
        Console.WriteLine($"Сума елементів в стовпцях з від'ємними елементами: {sumColumnsWithNegative}");

        FindSaddlePoints(matrix);
    }

    static int SumColumnsWithNegative(int[,] matrix)
    {
        int sum = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] < 0)
                {
                    sum += matrix[row, col];
                    break; // Переходимо до наступного стовпця
                }
            }
        }
        return sum;
    }

    static void FindSaddlePoints(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentElement = matrix[row, col];
                bool isSaddlePoint = true;

                // Перевіряємо чи є елемент сідловою точкою
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (currentElement > matrix[row, k])
                    {
                        isSaddlePoint = false;
                        break;
                    }
                }

                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    if (currentElement < matrix[l, col])
                    {
                        isSaddlePoint = false;
                        break;
                    }
                }

                if (isSaddlePoint)
                {
                    Console.WriteLine($"Сідлова точка: [{row}, {col}]");
                }
            }
        }
    }
}