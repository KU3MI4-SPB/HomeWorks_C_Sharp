// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNum(int m, int n)
{
    if (m == n) return m;
    int sum = m + SumNum(m + 1, n);
    return sum;
}

System.Console.WriteLine("Введите первое число M:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число N:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(m, n);
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {sum}");
