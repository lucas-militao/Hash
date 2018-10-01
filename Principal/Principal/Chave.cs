using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Chave
    {
        private int valor;
        private char livre;

        public Chave()
        {
            valor = 0;
            livre = 'L';
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public char Livre
        {
            get { return livre; }
            set { livre = value; }
        }
    }
}
