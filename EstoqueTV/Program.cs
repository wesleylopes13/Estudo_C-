using System;
using System.Globalization;

namespace EstoqueTV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando Classe Produto

            Produto prod;
            

            // Inserindo dados do produto

            Console.Write("Digito o produto: ");
            String nome = Console.ReadLine();

            Console.Write("\nDigite o preço do produto: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nDigite a quantidade de produtos no estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            prod = new Produto(nome, valor, qtd);
            // Exibindo os dados cadastrados
            prod.Exibir();
            
            // Instanciando método para adicionar produto
            prod.AdicionarProduto();
            prod.Exibir();
            
            // Instaciando método para remover produto
            prod.RemoverProduto();
            prod.Exibir();
                       
            // Manter o console aberto
            Console.ReadLine();
        }
    }
}
