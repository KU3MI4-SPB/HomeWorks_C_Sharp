// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[] { 1.2, 2.6, 3.1, 4.9, 5.7 };

double max = array[0];
double min = array[0];

foreach (double elem in array)
{
    if (elem > max)
        max = elem;
    if (elem < min)
        min = elem;
}

double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + diff);
