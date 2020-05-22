using System;
using System.Collections.Generic;

namespace CondicionaisELacos
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else

            Console.WriteLine("Informe sua idade:");
            //se a conversao for possivel idade recebera o valor convertido de 
            //String para inteiro, se nao for possivel converter, receberá zero
            int.TryParse(Console.ReadLine(), out int idade);

            if (idade <= 0)
            {
                Console.WriteLine("Por favor, insira uma idade válida.");
            }else if(idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }else if(idade>12 && idade < 18)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else { Console.WriteLine("Você é um adulto."); }

            //Operador ternario
            String msg = (idade >= 18) ? "Você maior de idade." : "Você não é maior de idade.";
            Console.WriteLine(msg);

            //List e Array

            string[] nomes = new string[3];
            nomes[0] = "Bruno";
            nomes[1] = "Leandro";
            nomes[2] = "Estela";

            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Pereira");
            sobrenomes.Add("Siqueira");
            sobrenomes.Add("Campos");

            Console.WriteLine($"{sobrenomes.Count} | {sobrenomes[0]}" );

            //Laços de repetição
            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Inscrito nº {i+1}: {nomes[i]} {sobrenomes[i]}");
            }

            foreach(String nome in nomes)
            {
                Console.WriteLine(nome);
            }

            sobrenomes.ForEach(sobrenome => Console.WriteLine(sobrenome));
        }
    }
}
