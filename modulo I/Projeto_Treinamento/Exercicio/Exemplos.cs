
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    public class Exemplos
    {
        public void FatorialNumeroQuatro()
        {
            int fatorial = 4 * 3 * 2 * 1; ;
            Console.WriteLine($"Fatorial quatro: 4 x 3 x 2 x 1 = {fatorial} ");
        }

        public int Fatorial(int numero)
        {
            int num = numero;
            int result = numero;
            while (num > 1)
            {
                result = result * (num - 1);
                Console.WriteLine("Result = " + result);
                Console.WriteLine("Num = " + num);
                num = num - 1;
            }

            return result;
        }

        public void ValorMaior(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"Valor Maior é : {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"Valor Maior é: {num2}");
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
        }

        public void ImparOuPar(int num1)
        {
            int result = num1 % 2;
            if (result == 0)
            {
                Console.WriteLine($"Número {num1} é par");
            }
            else
            {
                Console.WriteLine($"Número {num1} é impar");
            }

        }

        public void Calc(int num1, int num2, char operador)
        {
            decimal resultado1 = 0;
            switch (operador)
            {
                case '+':
                    resultado1 = num1 + num2;
                    break;
                case '-':
                    resultado1 = num1 - num2;
                    break;
                case '*':
                    resultado1 = num1 * num2;
                    break;
                case '/':
                    resultado1 = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operacao incorreto");
                    break;

            }
            Console.WriteLine($"O resultado da operacao é = {num1} {operador} {num2} = {resultado1}");
        }

        public void Tabuada(int num1)
        {
            Console.WriteLine($"Tabuada do número {num1}");

            for (int i = 1; i <= 10; i++)
            {
                int result_tabuada = num1 * i;
                Console.WriteLine($"{num1} * {i} = {result_tabuada}");
             }
        }

        public void Converter(double Graus, Char Medida)
        {
            if ((Medida == 'C') || (Medida == 'c')) // converter para Celsius
            {
                double NovoValor = ((Graus * 1.8) + 32.00);
                Console.WriteLine($"{Graus} Graus Farenheint correspondem a {NovoValor} Graus Celsius");
            }
            else if ((Medida == 'F') || (Medida == 'f')) // converter para Farenheint
            {
                double NovoValor = ((Graus - 32) / 1.8);
                Console.WriteLine($"{Graus} Graus Celsius correspondem a {NovoValor} Graus Farenheint");
            }
            else
            {
                Console.WriteLine("Conversos não identificado, utilize C ou F");
            }


        

        }

    }

   
}
