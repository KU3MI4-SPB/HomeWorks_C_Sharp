//Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет

InputNum:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2;

if (num < -9 || num > 9)
{
    num = Math.Abs(num);
    while (num >= 100)
    {
        num /= 10;
    }
    num2 = num % 10;
    Console.WriteLine("Вторая цифра слева: " + num2);
}
else
{
    Console.WriteLine("Число маленькое, введите большее число");
    goto InputNum;
}