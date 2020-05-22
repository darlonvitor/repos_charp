using System;
namespace HerancaPolimorfismo{
    public class Adulto : Pessoa{
        public Adulto(int id,string nome):base(id,nome)
        {
            
        }
        public override void Andar(){
            Console.WriteLine($"{Nome} está andando.");
        }
    }
}