// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("Исходный массив: ");
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

double[] CalculateColumnAverage(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);

    double[] avg = new double[n];

    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
            sum += arr[i, j];
        avg[j] = sum / m;
    }
    return avg;
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
double[] avg = CalculateColumnAverage(array);
Console.WriteLine();
Console.WriteLine("Средние арифметические по столбцам:");
for (int j = 0; j < cols; j++)
    Console.WriteLine($"Столбец {j + 1}: {avg[j]}");