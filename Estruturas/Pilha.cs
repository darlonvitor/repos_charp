
namespace Estruturas
{
    public class Pilha
    {

        // Uma pilha que irá armazenar inteiros
        private int[] Valores { get; set; }
        private int Topo { get; set; }

        public Pilha(){
            Valores = new int[10];
            Topo = -1;          // indica que a pilha está vazia
        }
        // insere elemento no topo da pilha
        public void Push(int elemento){
            Topo++; 
            Valores[Topo] = elemento;
        }

        // verifica se a pilha está vazia
        public bool IsEmpty(){
            return (Topo == -1);
        }

        // verifica se a pilha está cheia
        public bool IsFull(){
            return Topo == (Valores.Length - 1);
        }
        // remove elemento do topo da pilha
        public int Pop(){
            int elem = Valores[Topo];
            Topo--;
            return elem;
        }
    }
}