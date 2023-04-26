// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

IntDay:
Console.WriteLine("Введите цифрой день недели (1-7):");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной день!");
    }
    else
    {
        Console.WriteLine("Это рабочий день!");
    }
}
else
{
    goto IntDay;
}
