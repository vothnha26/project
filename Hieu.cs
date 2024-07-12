using System;

namespace Program
{
    class Program
    {
        static void Hieu(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Hieu(a, b);
        }
    }
}