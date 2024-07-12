using System;

namespace Program
{
    class Program
    {
        static void Tong(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Hieu(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Thuong(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Tich(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Tong(a, b);
            Hieu(a, b);
            Thuong(a, b);
            Tich(a, b);
        }
    }
}
