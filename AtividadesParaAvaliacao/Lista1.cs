using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AtividadesParaAvaliacao
{
    internal class Lista1
    {
        public void exercicio1()
        {
           // Console.BackgroundColor = ConsoleColor.Blue;
           // Console.ForegroundColor = ConsoleColor.White;
            //Console.Clear();
            string op;

            do
            {

                Console.Clear();
                Console.WriteLine(" ATIVIDADE 1 ");

                Console.WriteLine(" BOA SORTE!!! ");

                Console.ReadKey();
                Console.Clear();




                Console.WriteLine("1 - Exercício 1 /ola");
                Console.WriteLine("2 - Exercício 2 /nome e cargo");
                Console.WriteLine("3 - Exercício 3 /soma ");
                Console.WriteLine("4 - Exercício 4 /media");
                Console.WriteLine("5 - Exercício 5 /antecessor");
                Console.WriteLine("6 - Exercício 6 /x2, x3");
                Console.WriteLine("7 - Exercício 7 /kilometros");
                Console.WriteLine("8 - Exercício 8 /real em dolar");
                Console.WriteLine("9 - Exercicio 9 / altura ");


                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        seunome();
                        break;

                    case 2:
                        nomeecargo();

                        break;

                    case 3:
                        somade2numeros();
                        break;

                    case 4:
                        notadoaluno();
                        break;
                    case 5:
                        numeroantesedeois();
                        break;
                    case 6:
                        multiplique();
                        break;
                    case 7:
                        kilometros();
                        break;
                    case 8:
                        valordinheiro();
                        break;
                    case 9:
                        alturadaparede();
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

        private void alturadaparede()
        {
            // Solicita a entrada do usuário
            Console.Write("Digite a largura da parede (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da parede (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcula a área da parede
            double area = largura * altura;

            // Calcula a quantidade de tinta necessária
            double litrosTinta = area / 2;

            // Exibe os resultados
            Console.WriteLine($"A área da parede é {area} metros quadrados.");
            Console.WriteLine($"Você precisará de {litrosTinta} litros de tinta para pintar a parede.");
        }

        private void valordinheiro()
        {
            // Solicita a entrada do usuário
            Console.Write("Digite quanto dinheiro você tem na carteira (em R$): ");
            double dinheiroReais = Convert.ToDouble(Console.ReadLine());

            // Taxa de conversão
            double taxaConversao = 3.45;

            // Converte para dólares
            double dinheiroDolares = dinheiroReais / taxaConversao;

            // Exibe o resultado
            Console.WriteLine($"Com R${dinheiroReais}, você pode comprar US${dinheiroDolares:F2}.");
        }

        private void valor()
        {
            throw new NotImplementedException();
        }

        private void kilometros()
        {
            Console.Write("Digite uma distância em metros: ");
            double distanciaMetros = Convert.ToDouble(Console.ReadLine());

            // Converte a distância para outras unidades
            double km = distanciaMetros / 1000;
            double hm = distanciaMetros / 100;
            double dam = distanciaMetros / 10;
            double dm = distanciaMetros * 10;
            double cm = distanciaMetros * 100;
            double mm = distanciaMetros * 1000;

            // Exibe os resultados
            Console.WriteLine($"A distância de {distanciaMetros}m corresponde a:");
            Console.WriteLine($"{km}Km");
            Console.WriteLine($"{hm}Hm");
            Console.WriteLine($"{dam}Dam");
            Console.WriteLine($"{dm}dm");
            Console.WriteLine($"{cm}cm");
            Console.WriteLine($"{mm}mm");
        }

        private void multiplique()
        {
            decimal n1;
            Console.WriteLine(" digite o numero :");
            n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($" multiplicado por   {n1} é {n1 * 2}\n e o triplo é  {n1/3}");
        }

        private void numeroantesedeois()
        {
            decimal n1;
            Console.WriteLine(" digite o numero :");
            n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($" o antecessor de {n1} é {n1 - 1}\n e o sucessor  {n1 + 1}");



        }

        private void notadoaluno()
        {
            decimal n1, n2, resultado, media;
            Console.WriteLine(" digite a nota do aluno: \n");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite a segunda nota do aluno: \n");
            n2 = decimal.Parse(Console.ReadLine());
            resultado = (n1 + n2) / 2;
            Console.WriteLine(" A média é: " + resultado);

        }

        private void somade2numeros()
        {
            decimal n1, n2, resultado;
            Console.WriteLine(" digite o numero \n");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite o numero \n");
            n2 = decimal.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine(" A soma é? " + resultado);

        }

        private void nomeecargo()
        {
            string nome;
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine(" tecnico " + nome + " Salario 3.000,00 \n");
        }

        private void seunome()
        {
            string nome;
            Console.WriteLine(" digite seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine(" Ola " + nome + " Prazer em te conhecer \n ");
        }
    }
}
