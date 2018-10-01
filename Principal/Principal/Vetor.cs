using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Vetor
    {
        private Chave[] vet;

        public Vetor(int comprimento)
        {
            vet = new Chave[comprimento];
        }

        public Chave[] Vet
        {
            get { return vet; }
            set { vet = value; }
        }

    }
}
