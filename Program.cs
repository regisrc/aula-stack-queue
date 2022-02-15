using System;
using aula.paralelismo;

namespace aula
{
    class Program
    {
        static int[] elementos = new int[5];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();

            // Console.WriteLine("Escolha uma das opções...");
            // Console.WriteLine("1. Search");
            // Console.WriteLine("2. Sort");
            // Console.WriteLine("0. Sair");
            // Console.Write("Opção: ");

            // switch (Console.Read())
            // {
            //     case '1':
            //         Console.ReadLine();

            //         for(int i=0;i < elementos.Length; i++) {
            //             Console.WriteLine("Insira o numero da posição {0} ...", i);
            //             elementos[i] = Convert.ToInt32(Console.ReadLine());
            //         }

            //         var elementosOrdenados = SortMenu.Iniciar(elementos, true);

            //         SearchMenu.Iniciar(elementosOrdenados);

            //         break;
            //     case '2':
            //         Console.ReadLine();

            //         for(int i=0;i < elementos.Length; i++) {
            //             Console.WriteLine("Insira o numero da posição {0} ...", i);
            //             elementos[i] = Convert.ToInt32(Console.ReadLine());
            //         }

            //         SortMenu.Iniciar(elementos, false);
                    
            //         break;
            //     case '0':
            //         Environment.Exit(0);
            //         break;
            //     default:
            //         Console.WriteLine("Opção invalida, tente novamente...");
            //         break;
            // }

            System.Console.WriteLine("Insira a quantidade de operações:");
            
            var quantidade = Convert.ToInt32(Console.ReadLine());
            if (quantidade > 99)
            {
                Console.WriteLine("O número máximo de operações é 99");
                Main(args);
            }

            var calculo= (quantidade * 2);
            string[] initialNumbers = new string[calculo + 1];

            MenuCalculadora.Menu(initialNumbers, calculo);
            Main(args);
        }
    }
}