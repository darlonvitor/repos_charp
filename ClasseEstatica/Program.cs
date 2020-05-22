using System;

namespace ClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //HerancaPolimorfismo.Adulto kid = new HerancaPolimorfismo.Adulto();
            Console.WriteLine($"Soma de inteiros: {Calculadora.Somar(1,2)}");
            Console.WriteLine($"Soma de doubles: {Calculadora.Somar(1,2.5)}");
        }
    }
}
