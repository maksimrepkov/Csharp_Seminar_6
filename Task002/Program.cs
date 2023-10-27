// Задача № 43.
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и
// y = k2 * x + b2. Значения b1, k1, b2, k2 задаются пользователем. 

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

bool CheckLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают!");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны!");
            return false;
        }
    }
    return true;
}

double[] FindCrossLinesPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    double[] Arr = new double[2];
    x = Math.Round(((y - b1) / k1), 1);
    Arr[0] = x;
    y = Math.Round((k2 * ((y - b1) / k1) + b2), 1);
    Arr[1] = y;
    return Arr;
}

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

if (CheckLines(b1, k1, b2, k2))
{
    double[] CrossCord = FindCrossLinesPoint(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения двух прямых y = k1 * x + b1 и y = k2 * x + b2 имеет координаты: ({CrossCord[0]}; {CrossCord[1]}).");
}