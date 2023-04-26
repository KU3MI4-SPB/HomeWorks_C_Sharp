// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

InputNum:
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int secnum = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра трехзначного числа {num}: {secnum}");
}
else
{
    Console.WriteLine("Число не трехзначное");
    goto InputNum;
}