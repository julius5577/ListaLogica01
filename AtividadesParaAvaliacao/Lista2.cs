using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesParaAvaliacao
{
    internal class Lista2
    {
        public object ABCvalores { get; private set; }

        public void exercicio2() 
        {
            string op;

            do
            {

                Console.Clear();
                Console.WriteLine(" ATIVIDADE 2 ");

                Console.WriteLine(" APROVEITE A EXPERIENCIA ");

                Console.ReadKey();
                Console.Clear();




                Console.WriteLine("1 - Exercício 1 /imprima se for maior que 20");
                Console.WriteLine("2 - Exercício 2 /se maior que 10 ");
                Console.WriteLine("3 - Exercício 3 /valores A B C ");
                Console.WriteLine("4 - Exercício 4 /Adição ");
                Console.WriteLine("5 - Exercício 5 /casado");
                Console.WriteLine("6 - Exercício 6 /Par impar");
                Console.WriteLine("7 - Exercício 7 /A+b se for =");
                Console.WriteLine("8 - Exercício 8 /Impar ou par");
                Console.WriteLine("9 - Exercicio 9 / Ordem numerica ");
                Console.WriteLine("10 - Exercicio 10 ordem numeria menor");
                Console.WriteLine("11 - Exercicio 11 / horas jogadas ");



                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        numeromaiorque20();
                        break;

                    case 2:
                        semaiorque10();

                        break;

                    case 3:
                        ABCvalore();

                        break;

                    case 4:
                       exercicio4();
                        break;
                    case 5:
                      casado();
                        break;
                    case 6:
                        parimpar();
                        break;
                    case 7:
                       amaisb();
                        break;
                    case 8:
                        valorimparouoar();
                        break;


                    case 9:
                        tresnumeros();
                        break;

                    case 10:
                        tresnumerosmenor();
                        break;

                    case 11:
                        somatresvalores();
                        break;









                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }



                Console.WriteLine(" deseja continuar NA LISTA: \n");
                op = Console.ReadLine().ToLower();


            } while (op == "s");
            Console.Clear();




        }

        private void somatresvalores()
        {
            int horainicio, horafim, duracao;
            Console.WriteLine("digite a hora do inicio do jogo ");
            horainicio =int.Parse(Console.ReadLine());

            Console.WriteLine(" digite a hora do fim do jogo :" );
            horafim =int.Parse(Console.ReadLine()); 

            if( horafim >= horainicio )
            {
              duracao = horafim - horainicio;

            }
            else 
            {
                duracao = (24 - horainicio) + horafim;
            }

            Console.WriteLine($" a duração do jodo é: {duracao} horas");

            if( duracao >24  ) 
            {
                Console.WriteLine($" tempo execedente : {duracao - 24} horas ");
            }

            else
            {
                Console.WriteLine($" teempo restante : {24 - duracao} horas ");
            }

        }

        private void tresnumerosmenor()
        {
            
            // Solicita a entrada dos três valores
            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            // Coloca os valores em um array
            int[] valores = { valor3,valor2, valor1};

            // Ordena o array do maior para o menor
            Array.Sort(valores);
            Array.Reverse(valores);

            // Exibe os valores ordenados
            Console.WriteLine("Os valores ordenados do maior para o menor são:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

        }

        private void tresnumeros()
        {
            
            // Solicita a entrada dos três valores
            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            // Coloca os valores em um array
            int[] valores = { valor1, valor2, valor3 };

            // Ordena o array do maior para o menor
            Array.Sort(valores);
            Array.Reverse(valores);

            // Exibe os valores ordenados
            Console.WriteLine("Os valores ordenados do maior para o menor são:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }

        private void valorimparouoar()
        {
            
            // Solicita a entrada do usuário
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Declara a variável para armazenar o resultado
            double resultado;

            // Verifica se o número é positivo ou negativo e calcula o resultado correspondente
            if (numero > 0)
            {
                resultado = numero * 2;
              Console.WriteLine($"{resultado} È possitivo");
            }
            else
            {
                resultado = numero * 3;
                Console.WriteLine($"{resultado} È Negativo ");
            }

            // Exibe o resultado
            Console.WriteLine($"O resultado é: {resultado}");
        }

        private void amaisb()
        {
            decimal na, nb, nc;
            Console.WriteLine(" digite o numero: ");
            na=decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite proximo numero: ");
            nb= decimal.Parse(Console.ReadLine());

            if(na==nb)
            {
                nc=na+nb;
         
            }
            else 
            {
              nc=na*nb;
            }
            Console.WriteLine($"o resultado de C é {nc}");
        }

        private void parimpar()
        {
            // Solicita a entrada do usuário
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }

        private void casado()
        {
            string nome, sexo, civil;
            decimal anos;
            Console.WriteLine(" digite seu nome: ");
            nome= Console.ReadLine();

            Console.WriteLine(" qual o seu sexo ? masculino ou femenino ?");
            sexo = Console.ReadLine().ToLower();

            Console.WriteLine("estado civil ");
            civil = Console.ReadLine();

            if (civil == "casada") 
            {
                Console.WriteLine("Qual otempo de casado(a) em anos ");
                anos = decimal.Parse(Console.ReadLine());
            }

        }

        private void exercicio4()
        {
            // Solicita a entrada dos valores inteiros
            Console.Write("Digite o primeiro valor : ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor : ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            // Efetua a adição dos valores
            int soma = valor1 + valor2;

            // Verifica se a soma é maior que 10 e exibe o resultado se for
            if (soma > 10)
            {
                Console.WriteLine($"A soma de {valor1} + {valor2} é {soma}, que é maior que 10.");
            }
        }

        private void ABCvalore()
        {
            // Solicita a entrada dos valores A, B e C
            Console.Write("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            // Verifica se a soma de A + B é menor que C e exibe a mensagem correspondente
            if (A + B < C)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
            }
        }

        private void semaiorque10()
        {
            // Solicita a entrada do usuário
            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            // Verifica se o valor é maior que 10 e exibe a mensagem correspondente
            if (valor > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }
        }

        private void numeromaiorque20()
        {
            // Solicita a entrada do usuário
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Verifica se o número é maior que 20 e imprime se for
            if (numero > 20)
            {
                Console.WriteLine($"O número {numero} é maior que 20.");
            }
        }
    }
}
