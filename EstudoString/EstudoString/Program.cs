using System;

namespace EstudoString
{
    class Program
    {
        //{ 23, 24, 25, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        public String Crypt(String msg)
        {
            String resp = System.String.Empty;
            if (msg != string.Empty)
            {
                if(msg == null)
                {
                    throw new System.ArgumentNullException();
                }
                                                                             // array com chave de encriptaçao
                int[] cifra = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 1, 2 };

                                                                             // alfabeto onde serao buscadas as correspondencias
                string abc = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";
                string esp = " "; 

                String aux = msg.ToLower();                                  // realizando conversao para minúsculas


                for (int i = 0; i < aux.Length; i++)
                {
                    string temp = Char.ToString(aux[i]);                     // convertendo explicitamente char para string
                    int indice = abc.IndexOf(temp);                          // verificando a ocorrencia do caractere no alfabeto

                    if (indice >= 0 && indice <= 25)
                    {
                        resp += abc[cifra[indice]];                          // subtituindo pela letra correspondente na cifra
                    }else if (numbers.IndexOf(temp) != -1 || temp == esp)
                    {
                        resp += aux[i];                       
                    }
                    else                                                     // se nao for numero, espaço ou letra será lançada a exceção
                    {
                        throw new System.ArgumentOutOfRangeException(); 
                    }
                }
            }
            return resp;
        }

        public String Decrypt(String msg)
        {
            String resp = System.String.Empty;
            if (msg != string.Empty)
            {
                if (msg == null)
                {
                    throw new System.ArgumentNullException();
                }
                // array com chave de encriptaçao
                int[] cifra = { 23, 24, 25, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

                // alfabeto onde serao buscadas as correspondencias
                string abc = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";
                string esp = " ";

                String aux = msg.ToLower();                                  // realizando conversao para minúsculas


                for (int i = 0; i < aux.Length; i++)
                {
                    string temp = Char.ToString(aux[i]);                     // convertendo explicitamente char para string
                    int indice = abc.IndexOf(temp);                          // verificando a ocorrencia do caractere no alfabeto

                    if (indice >= 0 && indice <= 25)
                    {
                        resp += abc[cifra[indice]];                          // subtituindo pela letra correspondente na cifra
                    }
                    else if (numbers.IndexOf(temp) != -1 || temp == esp)
                    {
                        resp += aux[i];
                    }
                    else                                                     // se nao for numero, espaço ou letra será lançada a exceção
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
            }
            return resp;
        }
        static void Main(string[] args)
        {

            // <========== DECLARAÇAO E INICIALIZAÇAO DE STRINGS ==========>
            
            //Declaraçao sem inicializaçao
            String msg1;

            //Inicializando com null
            String msg2 = null;

            //inicializando uma string vazia
            //recomenda-se o uso da constante empty ao invez do ""
            String msg3 = System.String.Empty;

            //inicializando uma string regular literal
            string s1 = "He said, \"This is the last \u0063hance\x0021\""; ;

            //inicializando uma string com o verbatim string literal
            string s2 = @"He said, ""This is the last \u0063hance\x0021""";

            Console.WriteLine($"string regular literal: {s1}");
            Console.WriteLine($"verbatim string literal: {s2}");

            //Podemos usar o System.String 
            System.String msg4 = "Ola mundo!";

            //tipagem implicita
            var msg5 = "Eu estou fortemente tipada como System.Stirng!";

            //Use uma constante para impedir que a string receba outro valor
            const string msg6 = "Voce nao pode me passar outro valor.";

            //Usar o construtor da String apenas quando a criamos a partir 
            //de um char*, char[], ou sbyte*
            char[] abc = { 'A', 'B', 'C' };
            String letras = new string(abc);

            Console.WriteLine(letras);

            //concatenando com o operador +
            string msg7 = "Uma string é mais "; 
            string msg8 = "que uma cadeia de caracteres\n";

            msg7 += msg8;
            Console.WriteLine(msg7);

            //interpolaçao de strings
            int dia = 02;
            int mes = 08;
            int ano = 1994;
            Console.WriteLine($"(Por interpolaçao) A data do meu nascimento é: {dia}/{mes}/{ano}");

            //Concatenado usando o string.format (formataçao composta)
            Console.WriteLine("(Utilizando formataçao composta) A data do meu aniversario é: {0}/{1}/{2}",dia,mes,ano);

            //obtendo uma substring
            Console.WriteLine(msg7.Substring(2,5));

            //substituindo valores
            Console.WriteLine(msg7.Replace(" ", "_"));

            //Encontrando a primeira ocorrencia de um caractere
            //retorna -1 se nao encontrar
            Console.WriteLine(msg7.IndexOf("X"));

            //acessando caracteres individuais somente leitura
            for(int i = 0; i < msg7.Length; i++)
            {
                Console.Write(msg7[msg7.Length -1 -i]);
            }

            Console.Write($"\n\n{new Program().Crypt("the quick brown fox jumps over the lazy dog")}");
            Console.Write($"\n\n{new Program().Decrypt("wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj")}\n");
            //Console.Write($"\n\n{new Program().Decrypt(null)}\n");

            Console.WriteLine(Char.GetNumericValue('4'));
        }
    }
}
