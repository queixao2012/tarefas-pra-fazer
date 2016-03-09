using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Lista
    {

        public Carro primeiro;
        public void inserirFinal(Carro n)
        {
            if (primeiro == null)
                primeiro = n;
            else if (primeiro.prox == null)
                primeiro.prox = n;
            else
            {
                Carro pr;
                for (pr = primeiro; pr.prox != null; pr = pr.prox)
                    pr.prox = n;
            }

        }
        public void Imprimir()
        {
            Carro p;
            if (primeiro != null)
            {
                for (p = primeiro; p.prox != null; p = p.prox)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine(p.ToString());
            }

        }
        public int Qtde()
        {
            int qtde;
            qtde = 0;

            return qtde;
        }
    }
}
