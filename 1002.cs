using System;
using System.Globalization;
//saida de dados Console.WriteLine()
//entrada de dados Console.ReadLine()
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        CultureInfo CI = CultureInfo.InvariantCulture;
        double area, n, raio;

        n = 3.14159;
        raio = double.Parse(Console.ReadLine(),CI);
        area = n * (raio*raio);
        System.Console.WriteLine("A="+area.ToString("F4", CI));
        }
    }
}
