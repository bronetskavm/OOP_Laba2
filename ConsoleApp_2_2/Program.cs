using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Обчислення коренів квадратного рівняння ax^2 + bx + c = 0");

        double a, b, c;

        if (TryGetValidInput(out a, "a") && TryGetValidInput(out b, "b") && TryGetValidInput(out c, "c"))
        {
            double discriminant = CalculateDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Дискримінант: {discriminant:F3}");
                Console.WriteLine($"Розв'язки: x1 = {x1:F3}, x2 = {x2:F3}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Дискримінант: {discriminant:F3}");
                Console.WriteLine($"Один розв'язок: x = {x:F3}");
            }
            else
            {
                Console.WriteLine("Розв'язків немає.");
            }
        }
        else
        {
            Console.WriteLine("Некоректні введені значення. Будь ласка, введіть дійсні числа.");
        }
    }

    static bool TryGetValidInput(out double value, string paramName)
    {
        Console.Write($"Введіть значення {paramName}: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out value))
        {
            return true;
        }
        else
        {
            value = 0;
            return false;
        }
    }

    static double CalculateDiscriminant(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }
}
