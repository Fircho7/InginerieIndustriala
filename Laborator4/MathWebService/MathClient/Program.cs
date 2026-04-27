using System;

namespace MathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathReference.MathService service = new MathReference.MathService();

            Console.Write("Introdu primul numar: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introdu al doilea numar: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Rezultate:");
            Console.WriteLine("Adunare: " + service.Adunare(a, b));
            Console.WriteLine("Scadere: " + service.Scadere(a, b));
            Console.WriteLine("Inmultire: " + service.Inmultire(a, b));
            Console.WriteLine("Impartire: " + service.Impartire(a, b));

            Console.ReadKey();
        }
    }
}