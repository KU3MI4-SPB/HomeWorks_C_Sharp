// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

InputNum:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Пожалуйста, введите число отличное от 0");
    goto InputNum;
}

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}