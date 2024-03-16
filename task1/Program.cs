using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        void rec(int m, int n)
        {
        if (m > n)
        return;
        if (m % 2 == 0)
        {
        Console.Write($"{m}, ");
        }
        rec(m+1,n);

        }
        rec(m,n);
    
    }
}