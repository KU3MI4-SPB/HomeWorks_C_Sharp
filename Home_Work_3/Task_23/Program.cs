// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int num)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}:");
    Console.WriteLine("{0,-10} {1,-10}", "Число", "Куб числа");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine("{0,-10} {1,-10}", i, i * i * i);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
