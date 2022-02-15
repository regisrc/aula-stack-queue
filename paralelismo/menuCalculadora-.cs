using System;
using System.Threading.Tasks;

namespace aula.paralelismo
{
  public class MenuCalculadora {

    public static void Menu(string[] array, int quantidadeOperacoes) {
            System.Console.WriteLine("CALCULADORA:");
            int teste = 0;
            while (teste != quantidadeOperacoes)
            {
              System.Console.WriteLine("Insira o número para a operação:");
              array[teste] = Console.ReadLine(); 

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
                    array[teste] = "+";
                    break;
                case '2':
                    Console.ReadLine();
                    teste++;
                    array[teste] = "-";
                    break;
                case '3':
                    Console.ReadLine();
                    teste++;
                    array[teste] = "*";
                    break;
                case '4':
                    Console.ReadLine();
                    teste++;
                    array[teste] = "/";
                    break;
                case '5':
                    Console.ReadLine();
                    teste++;
                    array[teste] = "^";
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
          array[teste] = Console.ReadLine(); 

          for (int i = 0; i < array.Length; i++)
          {
            Console.Write(array[i]);
          }
          Console.WriteLine("");

          allOperation(array);
        }

        public static void allOperation(string[] array) {
          Parallel.ForEach(array, campoArray =>
            {
              Console.WriteLine(Array.IndexOf(array, campoArray));
                if (campoArray == "^")
                {
                    var atual = Array.IndexOf(array, campoArray);
                    Console.WriteLine("INDEX ATUAL: " + atual);
                    var resultado = Math.Pow(Convert.ToInt32(array[atual - 1]), Convert.ToInt32(array[atual + 1]));
                    Console.WriteLine($"{array[atual - 1]}^{array[atual + 1]} = {resultado} ");
                }
          });

          Parallel.ForEach(array, campoArray =>
            {
              Console.WriteLine(Array.IndexOf(array, campoArray));
                if (campoArray == "/")
                {
                    var atual = Array.IndexOf(array, campoArray);
                    Console.WriteLine("INDEX ATUAL: " + atual);
                    var resultado = Convert.ToInt32(array[atual - 1]) / Convert.ToInt32(array[atual + 1]);
                    Console.WriteLine($"{array[atual - 1]}/{array[atual + 1]} = {resultado} ");
                }

                if (campoArray == "*")
                {
                    var atual = Array.IndexOf(array, campoArray);
                    Console.WriteLine("INDEX ATUAL: " + atual);
                    var resultado = Convert.ToInt32(array[atual - 1]) * Convert.ToInt32(array[atual + 1]);
                    Console.WriteLine($"{array[atual - 1]}*{array[atual + 1]} = {resultado} ");
                }
          });

          Parallel.ForEach(array, campoArray =>
            {
              Console.WriteLine(Array.IndexOf(array, campoArray));
                if (campoArray == "+")
                {
                    var atual = Array.IndexOf(array, campoArray);
                    Console.WriteLine("INDEX ATUAL: " + atual);
                    var resultado = Convert.ToInt32(array[atual - 1]) + Convert.ToInt32(array[atual + 1]);
                    Console.WriteLine($"{array[atual - 1]}+{array[atual + 1]} = {resultado} ");
                }

                if (campoArray == "-")
                {
                    var atual = Array.IndexOf(array, campoArray);
                    Console.WriteLine("INDEX ATUAL: " + atual);
                    var resultado = Convert.ToInt32(array[atual - 1]) - Convert.ToInt32(array[atual + 1]);
                    Console.WriteLine($"{array[atual - 1]}-{array[atual + 1]} = {resultado} ");
                }
          });
        }
  }
}