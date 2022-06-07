using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n (максимальное число) = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k (количество попыток) = ");
            int k = int.Parse(Console.ReadLine());
            Random R = new Random();
            int CHISLO = R.Next(1, n + 1);
            int[] K = new int[k];
            for (int i = 0; i < K.Length; i++)
            {
                if (i == K.Length - 1)
                {
                    Console.Write("введите число: ");
                    int chislo = int.Parse(Console.ReadLine());
                    if (chislo == CHISLO) Console.WriteLine("Вы угадали");
                    else Console.WriteLine("Попытки закончились");
                }
                else
                {
                    Console.Write("введите число: ");
                    int chislo = int.Parse(Console.ReadLine());
                    if (chislo == CHISLO)
                    {
                        Console.WriteLine("Вы угадали");
                        break;
                    }
                    else
                    {
                        if (chislo < CHISLO) Console.WriteLine("больше");
                        else Console.WriteLine("меньше");
                    }
                }
            }
        }
    }
}
