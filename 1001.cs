using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        int A, B, X;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        X = A + B;
        System.Console.WriteLine("X = "+X);
        }
    }
}