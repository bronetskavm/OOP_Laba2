using System;

class Program
{
    static void Main()
    {
        double x, y, z;

        Console.Write("Введiть значення x: ");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Введiть значення y: ");
            if (double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Введiть значення z: ");
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    double s = CalculateS(x, y, z);
                    Console.WriteLine($"Значення s: {s:F3}");
                }
                else
                {
                    Console.WriteLine("Некоректне введення для z. Будь ласка, введiть дiйсне число.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне введення для y. Будь ласка, введiть дiйсне число.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне введення для x. Будь ласка, введiть дiйсне число.");
        }
    }

    static double CalculateS(double x, double y, double z)
    {
        // Обчислення значення s згідно з варіантом
        double s = Math.Log(x) * (Math.Pow((y + Math.Pow(x - 1, 1 / 3)), 1 / 4) / (2 * Math.Abs(x + z)));
        return s;
    }
}
