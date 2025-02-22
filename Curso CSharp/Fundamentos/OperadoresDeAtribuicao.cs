using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar ()
        {
            var num1 = 3;
            num1 += 7; // num1 = num1 + 10 (soma e depois atualiza o valor de num1
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            a++;
           
            Console.WriteLine(a);

        }
    }
}
