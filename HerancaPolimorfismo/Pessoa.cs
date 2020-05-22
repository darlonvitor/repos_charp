using System;

namespace HerancaPolimorfismo
{
    public abstract class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Nome { get; set; }
        public bool SexoFeminino { get; set; }

        public virtual void Comer(){Console.WriteLine($"Eu {Nome}, peguei os talheres e iniciei minha refeição.");}
        public virtual void Banho(){Console.WriteLine($"I {Nome} get a shower !!!");}

        public abstract void Andar();//método abstrato que devera ser implementado pelas classes filhas
    }
}
