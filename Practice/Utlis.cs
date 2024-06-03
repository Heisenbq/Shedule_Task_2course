using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Utlis
    {
        // Функция для вычисления размещений
        public static double CalculateArrangements(int n, int k)
        {
            return Factorial(n) / Factorial(n - k);
        }

        // Функция для вычисления факториала
        public static double Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        // Функция для вычисления сочетаний
        public static double Combinations(int n, int k)
        {
            if (k < 0 || k > n)
                return 0;

            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }
}
