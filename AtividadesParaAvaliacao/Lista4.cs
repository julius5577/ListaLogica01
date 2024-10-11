using System;
using System.Collections.Generic;
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
                Console.WriteLine("2 - Exercício 2 /media por 4 ");
                Console.WriteLine("3 - Exercício 3 /se for joão pare ");
                Console.WriteLine("4 - Exercício 4 /quantidade numerica ");
                Console.WriteLine("5 - Exercício 5 /quantidade de impar");
                Console.WriteLine("6 - Exercício 6 /tabuada");



                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                      imparepar();
                        break;

                    case 2:
                      //  mediaporquatro();

                        break;

                    case 3:
                      //  paranojoao();

                        break;

                    case 4:
                      //  quantnum();
                        break;
                    case 5:
                      //  quantimp();
                        break;
                    case 6:
                      //  tabuada();
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
