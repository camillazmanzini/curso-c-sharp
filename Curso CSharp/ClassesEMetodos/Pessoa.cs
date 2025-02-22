using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
