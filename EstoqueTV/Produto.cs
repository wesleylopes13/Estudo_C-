using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace EstoqueTV
{
    class Produto
    {
        public String Nome;
        public double Valor;
        public int Qtd;

        public double ValorTotalEmEstoque()
        {
            return Valor * Qtd;
        }

        public void AdicionarProduto()
        {            
            Console.Write("\n\nDigite a quantidade de produtos a serem inseridos: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            this.Qtd += quantidade;
        }

        public void RemoverProduto()
        {
            int quantily = 0;

            Console.Write("\n\nDigite a quantidade de produtos a serem removidos: ");
            quantily = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            this.Qtd -= quantily;            
        }

        public void Exibir()
        {

            Console.Write("\nProduto: " + Nome +
                "\nQuantidade: " + Qtd +
                 "\nValor total em estoque: R$" + ValorTotalEmEstoque());
        }
    }
}