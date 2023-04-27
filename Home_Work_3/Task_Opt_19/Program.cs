// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

bool Palindrome(int num1)
{
    int rev = 0;
    int orignum = num1;

    while (num1 > 0)
    {
        int digit = num1 % 10;
        rev = rev * 10 + digit;
        num1 /= 10;
    }
    return (orignum == rev);
}

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (Palindrome(num1))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
