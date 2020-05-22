using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseObjeto
{
    class Doguinho
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Porte { get; set; }
        public string NomeDoDono { get; set; }
        public string CorDoPelo { get; set; }

        public void Comer()
        {
            Console.WriteLine($"O doguinho {Nome} começou a comer.");
        }

        public string Latir()
        {
            return "Au Au Au";

        }

        public void Passear(bool estaChovendo)
        {
            string msg = estaChovendo ? $"O doguinho {Nome} não pode sair." : $"O doguinho {Nome} foi passear.";
            Console.WriteLine(msg);
        }
    }
}
