// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program
{
    static void Main(string[] args)
    {
        double[] coefficients = new double[4];

        Console.WriteLine("Введите значения b1, k1, b2 и k2:");

        for (int i = 0; i < coefficients.Length; i++)
        {
            Console.Write($"Коэффициент {i + 1}: ");
            coefficients[i] = double.Parse(Console.ReadLine());
        }

        double x = (coefficients[2] - coefficients[0]) / (coefficients[1] - coefficients[3]);
        double y = coefficients[1] * x + coefficients[0];

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
        Console.ReadLine();
    }
}