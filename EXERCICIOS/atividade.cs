using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading;

using System.Threading.Tasks;



namespace EXERCITANDO

{

    internal class Program

    {

        static void Main(string[] args)

        {

            ExibirCabecalho();

            ExibirOpcoesMenu();

        }



        public static void ExibirCabecalho()

        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("**********************\n");

            Console.WriteLine("victor: ");

            Console.WriteLine("\n**********************");

            Console.ResetColor();

        }



        public static void ExibirOpcoesMenu()

        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n digite 0  para Sair");

            Console.WriteLine("\n digite 1 para atividade");

            Console.WriteLine("\n digite 2 para atividade");

            Console.WriteLine("\n digite 3 para atividade");

            Console.WriteLine("\n digite 4 para atividade");

            Console.WriteLine("\n digite 5 para atividade");

            Console.WriteLine("\n digite 6 para atividade");

            Console.WriteLine("\n bonus ");



            string opcaoEscolhida = Console.ReadLine();

            int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);



            switch (opcaoEscolhidaNumero)

            {

                case 1:

                    at01();

                    break;



                case 2:

                    at02();

                    break;



                case 3:

                    at03();

                    break;


                case 4:

                    at04();

                    break;

                case 5:

                    at05();

                    break;


                case 6:

                    at06();

                    break;



                case 0:

                    Console.Clear();

                    Console.WriteLine("\n saindo...");

                    Thread.Sleep(3000);

                    break;



                default:

                    Console.WriteLine("\n voce digitou uma opcao invalida");

                    Thread.Sleep(3000);

                    Console.Clear();

                    ExibirCabecalho();

                    ExibirOpcoesMenu();

                    break;

            }

        }



        private static void at01()

        {

            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 01");

            Console.WriteLine("2.\nCrie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");



            Console.WriteLine("\n");

            Console.WriteLine("Digite sua idade:");

            int idade = int.Parse(Console.ReadLine());

            string resultado = VerificarIdade(idade);

            Console.WriteLine(resultado);

        }



        static string VerificarIdade(int idade)

        {

            if (idade >= 18)

            {

                return "Você é maior de idade.";

            }

            else

            {

                return "Você é menor de idade.";

            }

        }



        private static void at02()

        {

            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 02");

            Console.WriteLine("\n");

            Console.WriteLine("Crie um programa que leia três números e determine qual é o maior.");

            Console.WriteLine("\n");



            Console.WriteLine("Digite o primeiro número:");

            int num1 = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite o segundo número:");

            int num2 = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite o terceiro número:");

            int num3 = int.Parse(Console.ReadLine());



            int maior = DeterminarMaior(num1, num2, num3);

            Console.WriteLine("O maior número é: " + maior);

        }

        static int DeterminarMaior(int a, int b, int c)
        {
            int maior = a;
            if (b > maior)
            {
                maior = b;
            }
            if (c > maior)
            {
                maior = c;
            }
            return maior;
        }


        private static void at03()
        {

            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 02");

            Console.WriteLine("\n");

            Console.WriteLine("8. Crie um programa que determine se um ano é bissexto.");


            Console.Write("Digite seu peso em kg e sua altura em metros, separados por espaço: ");
            string[] inputs = Console.ReadLine().Split(' ');

            double peso = Convert.ToDouble(inputs[0]);
            double altura = Convert.ToDouble(inputs[1]);

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal.");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Classificação: Acima do peso.");
            }
            else
            {
                Console.WriteLine("Classificação: Obeso.");
            }

        }

        private static void at04()
        {
            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 04");

            Console.WriteLine("\n");

            Console.WriteLine("Escreva um programa que leia um mês do ano e informe quantos dias ele tem.");

            Console.WriteLine("\n");

            Console.WriteLine("escreva um mes deejado");

            int mes = int.Parse(Console.ReadLine());
            int dias;

            switch (mes)
            {
                case 1: // Janeiro
                case 3: // Março
                case 5: // Maio
                case 7: // Julho
                case 8: // Agosto
                case 10: // Outubro
                case 12: // Dezembro
                    dias = 31;
                    break;
                case 4: // Abril
                case 6: // Junho
                case 9: // Setembro
                case 11: // Novembro
                    dias = 30;
                    break;
                case 2: // Fevereiro
                    Console.WriteLine("Digite o ano:");
                    int ano = int.Parse(Console.ReadLine());
                    dias = (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0)) ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Mês inválido. Digite um número entre 1 e 12.");
                    return; // Encerra o código em caso de mês inválido
            }

            Console.WriteLine($"O mês {mes} tem {dias} dias.");




        }

        private static void at05()
        {
            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 05");

            Console.WriteLine("\n");

            Console.WriteLine("Faça um programa que verifique se um triângulo é equilátero, isósceles ou escaleno com base nos comprimentos de seus lados");

            Console.WriteLine("\n");


            Console.WriteLine("Digite o comprimento do primeiro lado do triângulo:");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do segundo lado do triângulo:");
            double lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terceiro lado do triângulo:");
            double lado3 = double.Parse(Console.ReadLine());

            // Verifica se é um triângulo válido
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 ||
                lado1 + lado2 <= lado3 ||
                lado1 + lado3 <= lado2 ||
                lado2 + lado3 <= lado1)
            {
                Console.WriteLine("Os comprimentos fornecidos não formam um triângulo válido.");
            }
            else
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }


        }

        private static void at06()
        {
            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("\nVoce escolheu o exercicio 06");

            Console.WriteLine("\n");

            Console.WriteLine("Faça um programa que leia um número e verifique se ele está entre 1 e 100.");

            Console.WriteLine("\n");


            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número está entre 1 e 100
            if (numero >= 1 && numero <= 100)
            {
                Console.WriteLine("O número está entre 1 e 100.");
            }
            else
            {
                Console.WriteLine("O número está fora do intervalo de 1 a 100.");
            }





        }
    }
}