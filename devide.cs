using System;

namespace Program
{
    class Program
    {
        static void Hieu_2so(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Hieu_2so(a, b);
        }
    }
}