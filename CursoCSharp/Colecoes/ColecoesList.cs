using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }

    }
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro); // Adicionar o elemento na lista

            var combo = new List<Produto>
            {
                new Produto("Camisa", 89.9),
                new Produto("iPhone 14", 6499.9),
                new Produto("Power Bank", 299.9)
            };

            carrinho.AddRange(combo); // Adicionar vários elementos na lista
            Console.WriteLine(carrinho.Count); // Tamanho da lista
            carrinho.RemoveAt(3); // Remover indice da lista

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

        }
    }
}
