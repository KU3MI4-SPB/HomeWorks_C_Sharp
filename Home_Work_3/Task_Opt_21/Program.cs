// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

double DistN(double[] point1, double[] point2)
{
    double sumSquares = 0;
    for (int i = 0; i < point1.Length; i++)
    {
        double diff = point1[i] - point2[i];
        sumSquares += Math.Pow(diff, 2);
    }

    double distance = Math.Sqrt(sumSquares);
    return distance;
}

Console.Write("Введите количество измерений: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] point1 = new double[N];
double[] point2 = new double[N];
Console.WriteLine("Введите координаты первой точки:");

for (int i = 0; i < N; i++)
{
    Console.Write("Координата {0}: ", i + 1);
    point1[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите координаты второй точки:");

for (int i = 0; i < N; i++)
{
    Console.Write("Координата {0}: ", i + 1);
    point2[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Расстояние между точками: {Math.Round(DistN(point1, point2), 2)}");
