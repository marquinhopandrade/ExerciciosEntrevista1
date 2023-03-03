using System;

namespace ExerciciosEntrevista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;
            while (k < indice)
            {
                k = k + 1;
                soma = k + k;
            }
            Console.WriteLine(soma);
        }
    }
}
