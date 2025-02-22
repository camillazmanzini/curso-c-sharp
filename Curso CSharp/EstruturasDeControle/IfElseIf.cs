using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.EstruturasDeControle
{
    class IfElseIf
    {
        public static void Executar() 
        {
            Console.Write("Digite a nota do aluno aqui:");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra!");
            } 
                else if (nota >= 6.0)
                {
                    Console.WriteLine("Aprovado!");
                }
                else if (nota >= 3.0)
                {
                Console.WriteLine("Recuperação!");
                }
                else
                {
                Console.WriteLine("Reprovado!");
                }
        }
                    
        }
    }