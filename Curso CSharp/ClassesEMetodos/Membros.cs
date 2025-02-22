using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() 
        { 
            Pessoa aleatoria = new Pessoa();
            aleatoria.Nome = "Camilla";
            aleatoria.Idade = 21;

            //Console.WriteLine($"{aleatoria.Nome} tem {aleatoria.Idade} anos.");

            aleatoria.ApresentarNoConsole();
        }
    }
}
