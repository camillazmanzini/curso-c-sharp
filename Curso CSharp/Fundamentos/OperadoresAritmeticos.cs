using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preço Desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total*desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 60.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura,2);
            Console.WriteLine($"IMC é {imc}.");

            //Número Par ou Impar?
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}