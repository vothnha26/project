using System;

namespace Program
{
    class Program
    {
        static void Nhan2so(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Nhan2so(a, b);
        }
    }
}