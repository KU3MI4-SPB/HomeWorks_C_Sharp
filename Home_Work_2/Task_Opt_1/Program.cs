// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

IntNum:
Console.WriteLine("Введите число:");
string input = Console.ReadLine();
double number;

if (double.TryParse(input, out number))
{
    int length = input.Length;
    if (length > 1)
    {
        string resultString = "";
        for (int i = 0; i < length; i++)
        {
            if (i != 1)
            {
                resultString += input[i];
            }
        }

        double resultNumber;
        if (double.TryParse(resultString, out resultNumber))
        {
            Console.WriteLine($"Новое число: {resultNumber}");
        }       
    }
    else
    {
        Console.WriteLine("Введённое число однозначное, введите число больше 10");
        goto IntNum;
    }
}
else
{
    goto IntNum;
}