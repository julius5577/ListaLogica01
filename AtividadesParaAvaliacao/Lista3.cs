using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesParaAvaliacao
{
    internal class Lista3
    {
        public  void exercico3 ()
        {
            string op;

            do
            {

                Console.Clear();
                Console.WriteLine(" ATIVIDADE 3 ");

                Console.WriteLine(" QUASE NO FIM ");

                Console.ReadKey();
                Console.Clear();




                Console.WriteLine("1 - Exercício 1 /soma de 3 valores ");
                Console.WriteLine("2 - Exercício 2 /media por 4 ");
                Console.WriteLine("3 - Exercício 3 /se for joão pare ");
                Console.WriteLine("4 - Exercício 4 /quantidade numerica ");
                Console.WriteLine("5 - Exercício 5 /quantidade de impar");
                Console.WriteLine("6 - Exercício 6 /tabuada");



                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        tresvalores();
                        break;

                    case 2:
                        mediaporquatro();

                        break;

                    case 3:
                      paranojoao();

                        break;

                    case 4:
                      quantnum();
                        break;
                    case 5:
                      quantimp();
                        break;
                    case 6:
                      tabuada();
                        break;




                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }



                Console.WriteLine(" deseja continuar na lista: \n");
                op = Console.ReadLine().ToLower();


            } while (op == "s");
            Console.Clear();

        }

        private void tabuada()
        {
            int numero;
            Console.WriteLine(" digite o numero para ver a sua tabuada: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine($" tabuada do {numero}");
                for (int i =1; i <= 10; i++)
            {
                Console.WriteLine($" {numero} X {i} = {numero * i}");
            }
        }

        private void quantimp()
        {
            int soma = 0;
            for (int i = 1; i <= 5000; i+=2)
            {
                soma += i;
            }
            Console.WriteLine($" a soma de todos os numeros impares de 1 até 5000 é: {soma}");

        }

        private void quantnum()
        {
            int inicio = 35, fim = 98111, quantpar = 0;
             for (int i = inicio ; i <= fim; i++) 
            {
                    if (i % 2 == 0)
                {
                    quantpar++;
                }
            }
            Console.WriteLine($" a quantidade de numeros pares entre {inicio} e {fim} é : {quantpar}");
        }

        private void paranojoao()
        {
            string nome,joao;

            do
            {
                Console.WriteLine(" digite o nome:");
                nome = Console.ReadLine();
            }
            while (nome != "joao");

            Console.WriteLine($" nome 'joao' digitado. fim do programa");


        }

        private void mediaporquatro()
        {
            decimal n1, n2,n3,n4, resultado, media;
            Console.WriteLine(" digite a nota do aluno: \n");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite a segunda nota do aluno: \n");
            n2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite a nota do aluno: \n");
            n3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(" digite a segunda nota do aluno: \n");
            n4 = decimal.Parse(Console.ReadLine());


            resultado = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine(" A média é: " + resultado);
        }

        private void tresvalores()
        {
            int vl1, vl2, vl3, soma;
            Console.WriteLine(" digite o primeiro valor");
            vl1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" digite o segundo valor: ");
            vl2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" digite o terceiro valor : ");
            vl3 = int.Parse(Console.ReadLine());

            soma = vl1 + vl2 + vl3;
            Console.WriteLine($" a soma dos valores é : {soma} ");
        }
    }
}
