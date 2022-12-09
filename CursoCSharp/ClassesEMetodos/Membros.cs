using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa(); // Construtor
            pessoa.Nome = "Laura";
            pessoa.Idade = 23;

            //Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");

            pessoa.ApresentarNoConsole();
            pessoa.Zerar();
            pessoa.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Ronaldo";
            fulano.Idade = 28;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
