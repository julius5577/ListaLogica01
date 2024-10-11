using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesParaAvaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // editar cor 

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //chamndo as listas usa o static no public static void
            
            Lista1 lista1 = new Lista1();
            Lista2 lista2 = new Lista2();
            Lista3 lista3 = new Lista3();
            Lista4 lista4 = new Lista4();
            //Criando um manu com switch case
            string op;

            do
            {

                Console.Clear();
                Console.WriteLine(" !!! OLA MUNDO !!!");

                Console.WriteLine(" SEJA BENVINDO ");

                Console.ReadKey();
                Console.Clear();




                Console.WriteLine("1 - Exercício 1 da lista");
                Console.WriteLine("2 - Exercício 2 da lista");
                Console.WriteLine("3 - Exercício 3 da lista");
                Console.WriteLine("4 - Exercício 4 da lista");


                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        lista1.exercicio1();
                        break;

                    case 2:
                        lista2.exercicio2();
                        
                        break;

                    case 3:
                       lista3.exercico3();
                        break;

                        case 4:
                       lista4.exercicio4();
                        break;
                               
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }



                Console.WriteLine( " deseja continuar : \n");
                op = Console.ReadLine().ToLower();


            } while (op == "s");
        }

        private static void seunome()
        {
          



        }
    }
}
