using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Виберіть, яке значення ви хочете обчислити:");
        Console.WriteLine("1 - (1^n)+(2^(n/2))+...k^(n/k)");
        Console.WriteLine("2 - 1^k+2^k+...n^k");
        Console.WriteLine("3 - 1/(n)+2/(n^2)+3/(n^3)...k/(n^k)");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            int n, k;
            double result = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть значення n: ");
                    int.TryParse(Console.ReadLine(), out n);
                    Console.Write("Введіть значення k: ");
                    int.TryParse(Console.ReadLine(), out k);
                    result = CalculateFirstValue(n, k);
                    break;

                case 2:
                    Console.Write("Введіть значення n: ");
                    int.TryParse(Console.ReadLine(), out n);
                    Console.Write("Введіть значення k: ");
                    int.TryParse(Console.ReadLine(), out k);
                    result = CalculateSecondValue(n, k);
                    break;

                case 3:
                    Console.Write("Введіть значення n: ");
                    int.TryParse(Console.ReadLine(), out n);
                    Console.Write("Введіть значення k: ");
                    int.TryParse(Console.ReadLine(), out k);
                    result = CalculateThirdValue(n, k);
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    return;
            }

            Console.WriteLine($"Результат: {result:F3}");
        }
        else
        {
            Console.WriteLine("Невірний вибір.");
        }
    }

    static double CalculateFirstValue(int n, int k)
    {
        double result = 0;
        for (int i = 1; i <= k; i++)
        {
            result += Math.Pow(i, n / (double)i);
        }
        return result;
    }

    static double CalculateSecondValue(int n, int k)
    {
        double result = 0;
        for (int i = 1; i <= n; i++)
        {
            result += Math.Pow(i, k);
        }
        return result;
    }

    static double CalculateThirdValue(int n, int k)
    {
        double result = 0;
        for (int i = 1; i <= k; i++)
        {
            result += i / Math.Pow(n, i);
        }
        return result;
    }
}
