using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Laura";
            // nome = 123; 
            Console.WriteLine(nome);

            // int idade;
            var idade = 32; // tipo implícito deve conter o valor quando declarado
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
