using System;
using ClasseEstatica;

namespace Interfaces
{
    class Program
    {
        public static void Ouvir(ISom som){
            som.EmitirSom();
        }

        static void Main(string[] args)
        {
            Gato tom = new Gato();
            Carro ferrari = new Carro();
            Ventilador tufao = new Ventilador();

            Console.WriteLine(Calculadora.Somar(1,2));

            Ouvir(tom);
            Ouvir(ferrari);
            Ouvir(tufao);
        }
    }
}
