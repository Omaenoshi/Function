using System;
using System.Threading;

namespace Function
{
    class Program
    {
        static double ReadValue()
        {
            try
            {
                double value = Convert.ToDouble(Console.ReadLine());
                return value;
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные.");
                return ReadValue();
            }
        }

        static double Function(double x)
        {
            double y = x * x;
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг построения.");
            double step = ReadValue();
            Console.WriteLine("Введите начальное значение диапазона х");
            double start = ReadValue();
            Console.WriteLine("Введите конечное значение диапазона х");
            double end = ReadValue();
            if (start <= end)
            {
                for (double i = start; ((i <= end && i >= start ) || ( i >= end && i <= start)); i += step)
                {
                    double y = Function(i);
                    Console.WriteLine($"y = {y}, x = {i}.");
                }
            }
            else
            {
                for (double i = start; (i >= end && i <= start); i -= step)
                {
                    double y = Function(i);
                    Console.WriteLine($"y = {y}, x = {i}.");
                }
            }


        }
    }
}
