using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string nome;
             bool inativo;
             int numero;
             long numero_1;
             decimal valor = 10_000_00;
             DateTime hoje = DateTime.Now; // Data Atual
             DateTime data_manual = new DateTime(2019, 09, 28);  // Data Manual
             string hoje_formatada = hoje.ToString("dd/MM/yyyy hh:mm:ss");
             string hoje_formatada_2 = hoje.ToString("T"); // Time
             char tipo;

             int[] array_int = new int[5];
             string[] array_string = new string[5];
             array_string[0] = "A";
             array_string[1] = "B";
             array_string[2] = "C";
             array_string[3] = "D";
             array_string[4] = "E";

             Console.WriteLine(">>" + hoje_formatada);
             Console.WriteLine($">>  {hoje_formatada_2} <<");
             Console.WriteLine($">>  {valor.ToString()} <<");

             Console.Write("Digite TESTE : ");
             string variavel_usuario = Console.ReadLine();

             Console.WriteLine($"Variavel :: {variavel_usuario}");


             if (variavel_usuario.ToUpper() == "TESTE")
             {
                 Console.WriteLine("Verdadeiro");
                 Console.WriteLine($"Valor digitado foi: {variavel_usuario}");
             }
             else
             {
                 Console.WriteLine("Falso");
                 Console.WriteLine($"Valor digitado foi: {variavel_usuario}");
             }

             Console.WriteLine($"Tamanho : {variavel_usuario.Length}");
             */

            Exemplos resultado = new Exemplos();
            resultado.FatorialNumeroQuatro();

            // Exercicio 2
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("---------  FATORIAL   -----------");
            Console.Write("Digite o valor: ");
            int numero = Convert.ToInt32(Console.ReadLine());
                     
                 
            Console.WriteLine($"Resultado do Fatorial é: {Convert.ToString(resultado.Fatorial(numero))}");

            // Exercicio 3 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---------  QUAL VALOR É MAIOR  -----------");

            Console.Write("Digite valor 1: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite valor 2: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Exemplos ValorMaior = new Exemplos();
            ValorMaior.ValorMaior(valor1, valor2);

            // Exercicio 4 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------ PAR OU IMPAR --------------");

            Console.Write("Digite valor para verificar se é par ou ímpar : ");
            int x = Convert.ToInt32(Console.ReadLine());

            resultado.ImparOuPar(x);

            // Exercicio 5 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("----------------- CALCULADORA -------------------");

            Console.Write("Digite valor 1 : ");
            int valor_calc1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite operador (+ - * /) : ");
            char operador = Convert.ToChar(Console.ReadLine());
            Console.Write("Digite valor 2 : ");
            int valor_calc2 = Convert.ToInt32(Console.ReadLine());

            resultado.Calc(valor_calc1, valor_calc2, operador);

            // Exercicio 6 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------------  TABUADA -------------------------");

            Console.Write("Digite um Número : ");
            int valor_tabuada = Convert.ToInt32(Console.ReadLine());
            resultado.Tabuada(valor_tabuada);

            // Exercicio 7 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("------------------  CONVERSOR DE GRAUS -------------------------");

            Console.Write("Digite a temperatura : ");
            int valor_temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Conversor, C para converter para Graus Celsius e F para converter para Farenheint");
            char conversor = Convert.ToChar(Console.ReadLine());
            resultado.Converter(Convert.ToDouble(valor_temp), conversor);

            Console.ReadKey();
                
        }   
    }
}
