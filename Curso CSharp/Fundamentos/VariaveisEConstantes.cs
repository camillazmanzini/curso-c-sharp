using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            //byte sem sinal
            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            //byte com sinal
            sbyte saldoDeGols = sbyte.MinValue; //byte com sinal
            Console.WriteLine("Saldo de Gols"+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            int menorValorInt = int.MinValue; // Mais usado entre os inteiros, tem sinal
            Console.WriteLine("Menor int" + menorValorInt);

            uint populaçãoBrasileira = 207_600_000; //sem sinal, unsigned. o underline facilita a leitura
            Console.WriteLine("População Brasileira" + populaçãoBrasileira);

            long menorValorLong = long.MinValue; //usado em contadores ou chaves hash
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; //unsigned
            Console.WriteLine("População Mundial"+ populacaoMundial);

            float precoComputador = 1299.99F; //não usado em medidas muito precisas
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000.00; //mais usado com precisao ex numeros financeiros
            Console.WriteLine("Valor de Mercado da Apple"+valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia Entre Estelas " + distanciaEntreEstrelas); //Numeros longos demais

            char letra = 'b';
            Console.WriteLine("Letra "+ letra);

            string frase = "Amor";
            Console.WriteLine("Frase " + frase);
        }
    }
}
