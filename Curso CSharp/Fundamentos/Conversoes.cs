﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            //Conversão numérica implícita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão numérica explícita
            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            //String -> inteiro
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse (palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
