using System;

namespace aula.paralelismo
{
  public class MenuCalculadora {

    public static void Menu(string[] initialNumbers, int quantidadeOperacoes) {
            System.Console.WriteLine("CALCULADORA:");
            int teste = 0;
            while (teste != quantidadeOperacoes)
            {
              System.Console.WriteLine("Insira o número para a operação:");
              initialNumbers[teste] = Console.ReadLine(); 

              Console.WriteLine("Escolha uma das opções da Calculadora...");
              Console.WriteLine("1. Soma");
              Console.WriteLine("2. Subtração");
              Console.WriteLine("3. Multiplicação");
              Console.WriteLine("4. Divisão");
              Console.WriteLine("5. Potenciação");
              Console.WriteLine("0. Sair");
              Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    teste++;
                    initialNumbers[teste] = "+";
                    break;
                case '2':
                    Console.ReadLine();
                    teste++;
                    initialNumbers[teste] = "-";
                    break;
                case '3':
                    Console.ReadLine();
                    teste++;
                    initialNumbers[teste] = "*";
                    break;
                case '4':
                    Console.ReadLine();
                    teste++;
                    initialNumbers[teste] = "/";
                    break;
                case '5':
                    Console.ReadLine();
                    teste++;
                    initialNumbers[teste] = "^";
                    break;
                case '0':
                    
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
           
           }
           teste++;
          }
          
          System.Console.WriteLine("Insira o número para a operação:");
          initialNumbers[teste] = Console.ReadLine(); 
          allOperation(initialNumbers);

        }

        public static void allOperation(string[] initialNumbers) {
          
          for (int i = 0; i < initialNumbers.Length; i++)
          {
            Console.Write(initialNumbers[i]);
          }
        }
  }
}