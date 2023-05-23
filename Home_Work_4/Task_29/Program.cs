// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray()
{
    Random random = new Random();
    int[] numbers = new int[8];
    System.Console.Write("Массив:");
    for (int x = 0; x < numbers.Length; x++)
        numbers[x] = random.Next(1, 100);
    return numbers;
}

void PrintArray(int [] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    System.Console.Write($" {numbers[x]}");
    Console.WriteLine();
}
 

int [] numbers = CreateArray();
PrintArray(numbers);
