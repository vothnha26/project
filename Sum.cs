using System;

namespace Program
{
    class Program
    {
        static void Tong(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            //tong
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Tong(a, b);
        }
    }
}