using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Montar montar = new Montar();

            BuilderVeiculo c1 = new FordKASedan();
            BuilderVeiculo c2 = new FiatUno();


            montar.Construir(c1);
            Veiculo v1 = c1.ObterVeiculo();
            v1.Exibir();


            montar.Construir(c2);
            Veiculo v2 = c2.ObterVeiculo();
            v2.Exibir();

            Console.ReadKey();

        }
    }
}
