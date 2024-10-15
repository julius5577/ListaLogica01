using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesParaAvaliacao
{
    internal class Lista4
    {
       public  void exercicio4()
        {

            string op;

            do
            {

                Console.Clear();
                Console.WriteLine(" ATIVIDADE 4 ");

                Console.WriteLine(" ULTIMA ATIVIDADE ");

                Console.ReadKey();
                Console.Clear();




                Console.WriteLine("1 - Exercício 1 /Impar e par  ");
                Console.WriteLine("2 - Exercício 2 /Idade ");
                Console.WriteLine("3 - Exercício 3 /Avaliação de aluno");
                Console.WriteLine("4 - Exercício 4 /Massa corporal ");
                Console.WriteLine("5 - Exercício 5 /maior de dois numeros");
                Console.WriteLine("6 - Exercício 6 /Idade de voto");
                Console.WriteLine("7 - Exercício 7 /Desconto ");
                Console.WriteLine("8 - Exercício 8 /Temperatura");
                Console.WriteLine("9 - Exercício 9 /Tres numeros");
                Console.WriteLine("10 - Exercício 10 /Ano bissexto");



                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                      imparepar();
                        break;

                    case 2:
                      idade();

                        break;

                    case 3:
                      aprovado();

                        break;

                    case 4:
                      Imc();
                        break;
                    case 5:
                      maiordedoisnumeros();
                        break;
                    case 6:
                      idadevoto();
                        break;
                    case 7:
                        desconto();
                        break;

                    case 8:
                        temperatura();
                        break;
                     case 9:
                        tresnumeros();
                        break;
                     case 10:
                        anobissexto();
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

        private void anobissexto()
        {
            
            Console.Write("Informe um ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            // Verifica se o ano é bissexto
            bool isBissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);

            // Exibe o resultado
            if (isBissexto)
            {
                Console.WriteLine($"{ano} é um ano bissexto.");
            }


            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto.");
            }

        }

        private void tresnumeros()
        {
            
            Console.Write("Informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            // Calcula a média
            double media = (numero1 + numero2 + numero3) / 3;

            // Verifica se a média é maior que 7 e exibe o resultado
            if (media > 7)
            {
                Console.WriteLine($"Média: {media:F2} - Aprovado");
            }
            else
            {
                Console.WriteLine($"Média: {media:F2} - Reprovado");
            }
        }

        private void temperatura()
        {
            
            Console.Write("Informe a temperatura em graus Celsius: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            // Classifica a temperatura
            string classificacao;
            if (temperatura < 15)
            {
                classificacao = "Frio";
            }
            else if (temperatura >= 15 && temperatura <= 25)
            {
                classificacao = "Agradável";
            }
            else
            {
                classificacao = "Quente";
            }

            // Exibe a classificação
            Console.WriteLine($"A temperatura está: {classificacao}");

        }

        private void desconto()
        {
            ;
            Console.Write("Informe o valor da compra: R$ ");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            // Verifica se o valor é superior a R$100 e aplica o desconto se necessário
            if (valorCompra > 100)
            {
                valorCompra *= 0.90; // Aplica um desconto de 10%
                Console.WriteLine($"Desconto aplicado! O valor final da compra é: R$ {valorCompra:F2}");
            }
            else
            {
                Console.WriteLine($"O valor da compra é: R$ {valorCompra:F2}");
            }
        }

        private void idadevoto()
        {
           
            Console.Write("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Determina a obrigatoriedade do voto
            string mensagem;
            if (idade < 16)
            {
                mensagem = "Você não pode votar.";
            }
            else if (idade >= 16 && idade < 18 || idade > 70)
            {
                mensagem = "Seu voto é facultativo.";
            }
            else
            {
                mensagem = "Você é obrigado a votar.";
            }

            // Exibe a mensagem
            Console.WriteLine(mensagem);
        }

        private void maiordedoisnumeros()
        {
            
            // Solicita o primeiro número do usuário
            Console.Write("Informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            // Solicita o segundo número do usuário
            Console.Write("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Compara os números e exibe o resultado
            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        private void Imc()
        {

            double imc, peso, altura;
            Console.Write("Informe seu peso atual: ");
            peso = double.Parse(Console.ReadLine());

            
            Console.Write("Informe sua altura  ");
             altura = double.Parse(Console.ReadLine());

             imc = peso / (altura * altura) ;

            
            
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso"); 
            }
            else if (imc >= 18.5 && imc <= 24.9)

            {
             
                
                     Console.WriteLine(" peso normal");
            }

            else if (imc >= 25 && imc <= 29.9)

            {
                
                Console.WriteLine(" sobre peso");
            }

            else if(imc >=30 && imc <=34.9)
            {
               
                Console.WriteLine("obesidade");
            }

            
           
        }

        private void aprovado()
        {
            double nota;
            Console.WriteLine(" digite a nota do aluno (de 0 a 10): ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6) 
            {
                Console.WriteLine(" Aprovado!");
            }
            else if (nota >= 4 && nota < 6) 
            {
                Console.WriteLine(" recuperação ");
            }
            else if (nota < 5) 
            {
                Console.WriteLine(" reprovado");
            }
        }

        private void idade()
        {
            int idade;
            Console.WriteLine(" digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
           
            if (idade >= 0 &&  idade <= 12) 
            {
                Console.WriteLine(" criança ");
            }

            else if (idade >= 13 && idade <= 17) 
            {
                Console.WriteLine(" adolecente ");
            }
            else if(idade >= 18 && idade <= 64)
            {
                Console.WriteLine(" adulto ");
            }
            else if (idade >= 65) 
            {
                Console.WriteLine(" idoso ");
            }


        }

        private void imparepar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
