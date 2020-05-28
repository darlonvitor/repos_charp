using System;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> nomes = new List<string>();
            nomes.Add("Paulo");
            nomes.Add("Cristiano");
            nomes.Add("Enzo");
            nomes.Add("Vitória");
            nomes.Add("Luana");
            nomes.Add("Jasmine");

            Console.WriteLine(nomes[0]);

            nomes.ForEach(n => {
                n += "!";
                Console.WriteLine(n);                
            });

            //SortedList
            SortedList<int,string> diario = new SortedList<int, string>();
            diario.Add(1,"Amanda");
            diario.Add(5,"Pedro");
            diario.Add(4,"Carlos");
            diario.Add(2,"Vanessa");

            //acessando elemento pela chave
            Console.WriteLine(diario[4]);
            
            //Dicionarios
            Dictionary<string,string> estados = new Dictionary<string, string>();
            estados.Add("CE","Ceará");
            estados.Add("PI","Piauí");
            estados.Add("MA","Maranhão");
            estados.Add("RN","Rio Grande do Norte");
            estados.Add("AL","Alagoas");
            estados.Add("SE","Sergipe");
            estados.Add("BA","Bahia");
            estados.Add("PB","Paraíba");

            Console.WriteLine(estados["PB"]);
            
            //Filas
            Queue<int> senhas = new Queue<int>();
            //adicionando elementos à fila
            senhas.Enqueue(1);
            senhas.Enqueue(2);
            senhas.Enqueue(3);
            senhas.Enqueue(4);

            var chamada = senhas.Dequeue();
            Console.WriteLine($"Senha chamada: {chamada} \nPróxima senha: {senhas.Peek()}");

            //Pilhas
            Stack<string> livros = new Stack<string>();
            livros.Push("Alice in the wonderland");
            livros.Push("I robot");
            livros.Push("The Man in the hight Castle");

            Console.WriteLine($"Estou lendo \'{livros.Pop()}\'.\nO próximo da fila é \'{livros.Peek()}\'");
        }
    }
}
