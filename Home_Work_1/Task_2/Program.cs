// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

InputNums:
Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num == num2)
{
    Console.WriteLine("Числа одинаковые, пожайлуста введите два разных числа");
    goto InputNums;
}

if (num > num2)
{
    Console.WriteLine($"Меньшее число - {num2}, а большее число - {num}");
}
else
{
    Console.WriteLine($"Меньшее число - {num}, а большее число - {num2}");
}