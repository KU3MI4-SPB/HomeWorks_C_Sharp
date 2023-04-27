// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

IntBool:
bool Palindrome(int num)
{
    int revnum = 0;
    int temp = num;
    while (temp > 0)
    {
        revnum = revnum * 10 + (temp % 10);
        temp /= 10;
    }
    return (num == revnum);
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Неверное число! Введите пятизначное число!");
    goto IntBool;
}

if (Palindrome(num))
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}