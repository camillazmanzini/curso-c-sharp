﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() 
        {
            var saudacao = "Olá".ToUpper().Insert(3, "World")
                            .Replace("World","Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste" .Length); //conta caracteres
        }
    }
}
