﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.EstruturasDeControle
{
    class If
    {
        public static void Executar() 
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno aqui:");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N)");
            entrada= Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            // bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) 
            {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}
