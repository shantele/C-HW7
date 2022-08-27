// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] CreateArray(int m, int n)  // m - строчки, n - столбцы
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(-9 + new Random().NextDouble() * (10 + 9), 1);
        }
    }
    return array;
}

double[,] resultArray = CreateArray(rows, columns);

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int m = 0; m < inputArray.GetLength(1); m++)
        {
            Console.Write(inputArray[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(resultArray);