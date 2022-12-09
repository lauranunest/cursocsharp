using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro); 

            var combo = new HashSet<Produto> // Estrutura não indexada
            {
                new Produto("Camisa", 89.9),
                new Produto("iPhone 14", 6499.9),
                new Produto("Power Bank", 299.9)
            };

            carrinho.UnionWith(combo); 
            Console.WriteLine(carrinho.Count); 
            //carrinho.RemoveAt(3); 

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

        }
    }
}
