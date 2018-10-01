using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor vetor = new Vetor(8);
            TabelaHashLinear tabelaLinear = new TabelaHashLinear(vetor);

            tabelaLinear.addElemento(35);

            tabelaLinear.Imprimir();

            Console.WriteLine(tabelaLinear.Buscar(35));

            tabelaLinear.RemoverElemento(35);

            Console.WriteLine(tabelaLinear.Buscar(35));

            Console.ReadKey();
        }
    }
}
