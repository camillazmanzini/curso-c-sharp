﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.EstruturasDeControle
{
    class While
    {
        public static void Executar() 
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) 
            {
                Console.Write("Insira seu palpite aqui:");
                string entrada = Console.ReadLine();
                int.TryParse (entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("É menor! Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else 
                { 
                    Console.WriteLine("É maior! Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }

            }
        }
    }
}
