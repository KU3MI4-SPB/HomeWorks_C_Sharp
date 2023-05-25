// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];

    }
    return sum;
}

int[] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив:");
PrintArray(array);
int sumNum = SumNumbers(array);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных индексах в массиве: {sumNum}");