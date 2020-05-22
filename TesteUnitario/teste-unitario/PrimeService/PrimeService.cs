using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            //como 2 eh o menor numero primo, nenhum numero menor que ele será primo
            if(candidate < 2){
                return false;
            }

            //verificando a existencia de algum divisor do numero
            for(var divisor = 2;divisor <= Math.Sqrt(candidate);divisor++){
                if(candidate%divisor==0){
                    return false;//se for divisivel por outro numero que nao ele mesmo e 1, nao sera primo
                }
            }
            return true;//se passar nos testes acima o numero eh primo
        }
    }
}
