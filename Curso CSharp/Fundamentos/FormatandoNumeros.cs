using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_CSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() 
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //F diz quantas casas decimais terá o número na string
            Console.WriteLine(valor.ToString("C")); //C transforma em moeda
            Console.WriteLine(valor.ToString("P")); //C transforma em percentual
            Console.WriteLine(valor.ToString("#.##")); // Define casas decimais
            
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); //Currency 0 casas decimais, cultura

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
