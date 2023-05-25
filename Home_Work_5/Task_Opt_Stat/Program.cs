// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
// вывести на экран с пояснениями. Найти медианное значение первоначального массива,
// возможно придется кое-что для этого дополнительно выполнить.


int length = 10;
Random rnd = new Random();
int[] numbers = new int[length];
for (int i = 0; i < length; i++)
{
    numbers[i] = rnd.Next(1, 101);
}

int max = numbers[0], min = numbers[0], maxIndex = 0, minIndex = 0;
for (int i = 1; i < length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
        maxIndex = i;
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
        minIndex = i;
    }
}

int sum = 0;
for (int i = 0; i < length; i++)
    sum += numbers[i];
double avg = (double)sum / length;

string[] info = {
    $"Максимальный элемент: {max}, индекс: {maxIndex}",
    $"Минимальный элемент: {min}, индекс: {minIndex}",
    $"Среднее арифметическое: {avg:F2}"
};

Console.WriteLine("Массив случайных чисел:");
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine();
Console.WriteLine("Информация о массиве:");
foreach (string s in info)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Array.Sort(numbers);
double median;
if (length % 2 == 0)
{
    median = ((double)numbers[length / 2] + (double)numbers[length / 2 - 1]) / 2;
}
else
{
    median = (double)numbers[length / 2];
}

Console.WriteLine($"Медианное значение: {median:F2}");
