// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int numBigger0 = 0;

for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        numBigger0++;
    }
    Console.WriteLine();
}

    int numEqual0 = numBigger0;
    if (numEqual0 <= 0)
    {
        Console.WriteLine("Среди введёных числе нет числа больше нуля"); 
    }
    else
    {
    Console.WriteLine($"Среди введёных числе {numBigger0} больше нуля");
    }
    Console.WriteLine();
*/

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
int firstN = -5;
int lastN = 6;
Random rand = new Random();
int k1 = rand.Next(firstN,lastN);
int k2 = rand.Next(firstN,lastN);
int b1 = rand.Next(firstN,lastN);
int b2 = rand.Next(firstN,lastN);
int x; int y;
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

if (k1 != k2)
{
    x = (b2-b1) / (k1-k2);
    y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения прямых [{x};{y}]");
}
else
{
    Console.WriteLine("У заданных прямых нет точек пересечения");
}
Console.WriteLine();
*/

