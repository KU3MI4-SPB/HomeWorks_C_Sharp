// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akker (int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akker(m - 1, 1);
    return Akker(m-1, Akker(m, n -1));
}

System.Console.WriteLine("Введите положительное число M:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите положительное число N:");
int n = Convert.ToInt32(Console.ReadLine());
int result = Akker(m,n);
System.Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен: {result}");
