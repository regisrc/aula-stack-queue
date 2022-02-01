using System;

namespace aula.searching
{
    public static class LinearSearch
    {
        public static void linearSearch(int numero, int[] elementos) {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == numero)
                {
                    Console.WriteLine("Busca feita com sucesso " + "O número " + elementos[i] + " foi encontrado no índice " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Busca falhou...");
                }
            }
        }
    }
}