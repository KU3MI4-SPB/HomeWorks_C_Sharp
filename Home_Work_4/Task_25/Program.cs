// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result *= a;
    return result;
}

System.Console.WriteLine("Ввведите натуральное число A:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввведите натуральное число B:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {a} в степени {b} равно: {Degree(a, b)}");
