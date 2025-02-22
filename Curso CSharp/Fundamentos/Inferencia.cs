using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            Console.WriteLine(nome);

            int idade; //declara a variavl
            idade = 32; //atribui
                        // int idade = 32 declara e inicializa (da a primeira atribuição)
            Console.WriteLine(idade);
        }
    }
}
