using System;

namespace T03_04
{

    class Program
    {
        static void Main(string[] args)
        {

            int N = 8;
            Console.WriteLine("N = " + N);
            N += 77;
            Console.WriteLine("N + 77 = " + N);
            N -= 3;
            Console.WriteLine("N - 3 = " + N);
            N *= 2;
            Console.WriteLine("N * 2 = " + N);
        }
    }
}
