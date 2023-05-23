// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4


int CountDig(double num)
{
     int count = 0;
     string number = num.ToString();
     for (int i = 0; i < number.Length; i++)
     {
        if (char.IsDigit(number[i]))
        {
            count++;
        }
     }
     return count;
}


System.Console.WriteLine("Введите целое или дробное число:");
double num = double.Parse(Console.ReadLine());
System.Console.WriteLine($"Количество цифр в цисле {num}: {CountDig(num)}");
