using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a sua nota:");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;
            
            Console.WriteLine("Nota válida? {0}", nota < 10.0);
            Console.WriteLine("Nota válida? {0}", nota > 0.0);
            Console.WriteLine("Nota Máxima? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
