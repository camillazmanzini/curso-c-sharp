using System;
using System.Collections.Generic;
using Curso_CSharp.ClassesEMetodos;
using Curso_CSharp.EstruturasDeControle;
using Curso_CSharp.Fundamentos;
using Curso_CSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Cap 1, Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},
                
                //Cap 2, Estruturas de Controle
                {"If - Estruturas de Controle", If.Executar},
                {"Else - Estruturas de Controle", Else.Executar},
                {"If Else If - Estruturas de Controle", IfElseIf.Executar},
                {"Switch - Estruturas de Controle", Switch.Executar},
                {"While - Estruturas de Controle", While.Executar},
                {"Do While - Estruturas de Controle", DoWhile.Executar},
                {"For - Estruturas de Controle", For.Executar},
                {"For Each - Estruturas de Controle", ForEach.Executar},
                {"Break - Estruturas de Controle", Break.Executar},
                {"Continue - Estruturas de Controle", Continue.Executar},

                 //Cap 3, Classes e Métodos
                 {"Membros - Classes e Métodos", Membros.Executar},
                 {"Construtores - Classes e Métodos", Construtores.Executar},
                 {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                 {"Método Estático - Classes e Métodos", MetodoEstatico.Executar},

            });
            central.SelecionarEExecutar();
        }
    }
}