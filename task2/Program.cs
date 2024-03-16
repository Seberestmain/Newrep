using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        AkkermanFunction(m,n);
        void AkkermanFunction(int m, int n)
        {
            Console.Write(Ack(m, n)); 
        }
        int Ack(int m, int n)
        {
                if (m == 0) 
                {
                    return n + 1;
                }
                else
                {
                    if (n == 0) 
                    {
                        return Ack(m - 1, 1);
                    }
                    else
                    {
                        return Ack(m - 1, Ack(m, n - 1));
                    } 
                }
            }
    }
}
