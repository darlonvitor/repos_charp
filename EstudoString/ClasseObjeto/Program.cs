using System;

namespace ClasseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando objeto Doguinho
            Doguinho mikey = new Doguinho();

            //preenchendo propriedades do mikey
            mikey.CorDoPelo = "Marrom";
            mikey.Nome = "Mikey Wasawsky"; 
            mikey.Id = 1;
            mikey.NomeDoDono = "Darlon";
            mikey.Porte = "Pequeno";

            mikey.Comer();
            Console.WriteLine(mikey.Latir());
            mikey.Passear(true);
        }
    }
}
