using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.EstruturasDeControle
{
    class For
    {
        public static void Executar() 
        {
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma aqui:");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) 
            {
                Console.Write("Informe a nota do aluno aqui: {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                
                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma:{0}", media);
        }
    }
}
