// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

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

Console.WriteLine("Введите позицию элемента в строке: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

if (rowPosition < 0 || rowPosition >= array.GetLength(0)
|| columnPosition < 0 || columnPosition >= array.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else Console.WriteLine($"Значение элемента: {array[rowPosition, columnPosition]}");