using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class TabelaHashLinear
    {
        private Vetor vet;

        public TabelaHashLinear(Vetor vet)
        {
            this.vet = vet;
            inicializarTabela();
        }

        public Vetor Vet
        {
            get { return vet; }
            set { vet = value; }
        }

        //inicializar Tabela com valores iniciais de chave---------------------------------------------------------------------------------
        private void inicializarTabela()
        {
            for(int i = 0; i < vet.Vet.Length; i++)
            {
                vet.Vet[i] = new Chave();
            }
        }

        //Adicionar novo elemento por Tentativa Linear-------------------------------------------------------------------------------------
        public void addElemento(int valor)
        {
            int pos = 0;
            int i = 0;
            char livre;

            do
            {
                pos = (valor + i) % vet.Vet.Length;
                livre = vet.Vet[pos].Livre;
                i++;
            } while (i < vet.Vet.Length && vet.Vet[pos].Livre != 'L' && vet.Vet[pos].Livre != 'R');

            if(vet.Vet[pos].Livre == 'O')
            {
                Console.WriteLine("Vetor encontra-se lotado!");
            }
            else
            {
                vet.Vet[pos].Livre = 'O';
                vet.Vet[pos].Valor = valor;
                Console.WriteLine("Valor adicionado com sucesso na posição: " + pos);
            }
        }

        //Buscar elemento por Tentativa Linear---------------------------------------------------------------------------------------------
        public int Buscar(int valor)
        {
            int pos = 0;
            int i = 0;

            do
            {

                pos = (valor + i) % vet.Vet.Length;
                i++;

            } while (i < vet.Vet.Length && vet.Vet[pos].Valor != valor);

            if (vet.Vet[pos].Valor == valor && vet.Vet[pos].Livre == 'O')
            {
                return pos;
            }

            return -1;
        }

        //Remover elemento por Tentativa Linear--------------------------------------------------------------------------------------------
        public void RemoverElemento(int valor)
        {
            int pos = Buscar(valor);

            if (pos > 0)
            {
                vet.Vet[pos].Livre = 'R';
                Console.WriteLine("Elemento removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Elemento não encontrado!");
            }
        }

        public void Imprimir()
        {
            for(int i = 0; i < vet.Vet.Length; i++)
            {
                Console.Write(vet.Vet[i].Valor + " ");
            }
            Console.WriteLine(" ");
        }

    }
}
