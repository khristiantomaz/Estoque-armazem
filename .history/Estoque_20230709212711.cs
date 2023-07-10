using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
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

        public override string ToString()
        {
            return Nome + ", $" + Preco;
        }

    }
}