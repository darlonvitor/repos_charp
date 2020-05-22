using System;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //duas sintaxes para preenchimento dos atributos

            Pessoa darlon = new Adulto(1,"Darlon");            
            darlon.DataDeNascimento = new DateTime(1994,8,2);          
            darlon.SexoFeminino = false;            

            darlon.Banho();
            darlon.Comer();            

            Pessoa duda = new Bebe(2,"Duda Camões"){
                DataDeNascimento = new DateTime(2019,04,18),
                SexoFeminino = true
            };

            duda.Comer();
            duda.Banho();
            duda.Andar();

    }
}
}
