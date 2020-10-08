using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Numeral Extenso");
            Console.Write("Digite qualquer número: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            string numeroExtenso = numeroDigitado.ToWords();
            Console.WriteLine($"Número por extenso: {numeroExtenso}");
        }
    }
}
