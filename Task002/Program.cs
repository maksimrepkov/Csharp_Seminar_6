// Задача № 43.
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и
// y = k2 * x + b2. Значения b1, k1, b2, k2 задаются пользователем. 

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;
double[] Arr = new double[2];
x = Math.Round(((y - b1) / k1), 1);
Arr[0] = x;
y = Math.Round((k2 * ((y - b1) / k1) + b2), 1);
Arr[1] = y;

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
Console.WriteLine($"({String.Join("; ",Arr)}).");
// Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({String.Join("; ",Arr)}).");  