using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Amarzem
{
    class Estoque
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }
        

    }
}