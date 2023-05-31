// Задача 50. Напишите программу, которая на вход принимает значение элемента
// в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        Console.WriteLine();
    }
}

(bool, int, int) FindElement(int[,] array, int find)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            if (array[i, j] == find)
                return (true, i, j);
    return (false, -1, -1);
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int find = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
(bool isFound, int row, int column) = FindElement(array, find);
if (isFound)
    Console.WriteLine($"Элемент {find} найден в позиции: ({row}, {column})");
else
    Console.WriteLine($"Элемент {find} не найден в массиве");