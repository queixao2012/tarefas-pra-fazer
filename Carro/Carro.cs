using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Carro
    {
        public string cor,modelo;
        public int ano;
        public Carro prox = null;
        public string ToString()
        {
            return "Cor: " + cor + " Ano: " + ano + " Modelo" + modelo;
        }
    }
}
