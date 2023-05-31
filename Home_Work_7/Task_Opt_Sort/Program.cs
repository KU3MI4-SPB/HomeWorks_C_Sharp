// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов 
// задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,30);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int[] rowArray = new int[cols];
        for (int j = 0; j < cols; j++)
            rowArray[j] = array[i, j];
        Array.Sort(rowArray);
        for (int j = 0; j < cols; j++)
            array[i, j] = rowArray[j];
    }
}

void SortColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int j = 0; j < cols; j++)
    {
        int[] colArray = new int[rows];
        for (int i = 0; i < rows; i++)
            colArray[i] = array[i, j];
        Array.Sort(colArray);
        for (int i = 0; i < rows; i++)
            array[i, j] = colArray[i];
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
SortArray(array);
SortColumns(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(array);
