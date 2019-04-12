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
            prod = new Produto();

            // Inserindo dados do produto

            Console.Write("Digito o produto: ");
            prod.Nome = Console.ReadLine();

            Console.Write("\nDigite o preço do produto: ");
            prod.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nDigite a quantidade de produtos no estoque: ");
            prod.Qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
