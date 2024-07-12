using System;

namespace Program
{
    class Program
    {
        static void Tich(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            //tich
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Tich(a, b);
        }
    }
}