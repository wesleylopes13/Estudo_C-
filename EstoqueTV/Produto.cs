using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace EstoqueTV
{
    class Produto
    {
        public String nome { get; set; }
        public double valor { get; set; }
        public int qtd { get; set; }

        public Produto(String nome, double valor, int qtd) 
        {
            this.nome = nome;
            this.valor = valor;
            this.qtd = qtd;
        }
        
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

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