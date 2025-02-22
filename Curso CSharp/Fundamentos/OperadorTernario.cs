using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() 
        {
            var nota = 8.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento  
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
