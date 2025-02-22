using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.EstruturasDeControle
{
    class ForEach
    {
        public static void Executar() 
        {
            var palavra = "Opa!";
            for (int i = 0; i < palavra.Length; i++)
            {
                Console.WriteLine(palavra[i]);
            }

            var Alunos = new string[] { "Ana", "Bia", "Carlos" };
            for (int i = 0; i < Alunos.Length; i++)
            {
                Console.WriteLine(Alunos[i]);
            }

            foreach (char letra in palavra)
            {
                Console.WriteLine(letra);
            }

            foreach (string aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
