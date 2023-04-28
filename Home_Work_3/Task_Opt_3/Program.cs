// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. 
// Напишите программу для проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана). Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения предикатов случайные, проверяем это утверждение 100 раз, с помощью модуля time выводим на экран, сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.


Random random = new Random();
int сount = 100;
DateTime startTime = DateTime.Now;

for (int i = 0; i < сount; i++)
{
    int preCount = new Random().Next(5, 26);

    bool[] predicates = new bool[preCount];

    for (int j = 0; j < preCount; j++)
    {
        predicates[j] = new Random().Next(2) == 1;
    }

    bool left = false;

    for (int j = 0; j < preCount; j++)
    {
        left = left || predicates[j];
    }

    left = !left;

    bool right = true;

    for (int j = 0; j < preCount; j++)
    {
        right = right && !predicates[j];
    }

    if (left != right)
    {
        Console.WriteLine("Проверка закончена");
        return;
    }
}

DateTime endTime = DateTime.Now;
Console.WriteLine($"Проверка теоремы Де Моргана пройдена {сount} раз");
Console.WriteLine($"Затраченное время: {(endTime - startTime).TotalMilliseconds} мс.");
