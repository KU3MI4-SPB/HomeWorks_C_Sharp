// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

InputNum:
Console.WriteLine("Введите число, большее чем 2");
int num = Convert.ToInt32(Console.ReadLine());
int start_num = 2;

if (num <= 2)
{
    Console.WriteLine("Пожалуйста, введите число больше чем 2");
    goto InputNum;
}

Console.WriteLine("Четные числа:");

while (start_num <= num)
{
    Console.Write(start_num);
    Console.Write(" ");
    start_num = start_num + 2;
}
