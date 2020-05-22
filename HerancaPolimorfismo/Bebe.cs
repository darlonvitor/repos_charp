using System;

namespace HerancaPolimorfismo
{
    public class Bebe : Pessoa
    {
        //chamando o construtor da classe mãe
        public Bebe(int id,string nome):base(id,nome)
        {
            
        }
        public override void Comer()
        {
            Console.WriteLine($"Algum adulto deu comida para {(SexoFeminino?"a":"o")} {Nome}");
        }

        public override void Banho(){
            Console.WriteLine($"Algum adulto deu banho n{(SexoFeminino?"a":"o")} {Nome}");
        }

        public override void Andar(){
            Console.WriteLine($"{(SexoFeminino?"A":"O")} {Nome} está andando e brincando.");
        }
    }

}