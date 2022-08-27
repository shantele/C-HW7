// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

double[] averageValue = new double[array.GetLength(1)];  // 4

for (int i = 0; i < array.GetLength(0); i++)
{
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == count)
        {
            averageValue[count] += array[i, j];
        }
        count++;
    }
}

for (int i = 0; i < averageValue.Length; i++)
{
    averageValue[i] = Math.Round((averageValue[i] / array.GetLength(0)), 1);  // 3
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {(String.Join("; ", averageValue))}.");