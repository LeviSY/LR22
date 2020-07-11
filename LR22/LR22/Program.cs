using System;

namespace LR22
{
    class Program
    {
        static int MinPoloj(int[] mas)
        {
            int num = int.MaxValue;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0 && mas[i] < num)
                    num = mas[i];
            }

            return num;
        }

        static void Main(string[] args)
        {
            int min = 10;
            int[] mas = new int[10];
            Random r = new Random();

            Console.WriteLine("Случайно сгенерированые числа");

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-10, 10);
                Console.Write(mas[i] + " \t ");
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Минимальное положительное число: ");

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min & mas[i] > 0)
                {
                    min = mas[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
