using System;

namespace aula.searching
{
    public static class BinarySearch
    {
        public static void binarySearch(int numero, int[] elementos) {
            int baixo = 0;
            int alto = elementos.Length - 1;

            while (baixo <= alto)
            {
                int medio = (baixo + alto) / 2;

                if (numero < elementos[medio])
                {
                    alto = medio - 1;
                }
                else if (numero > elementos[medio])
                {
                    baixo = medio + 1;
                }
                else if (numero == elementos[medio])
                {
                    Console.WriteLine("Busca feita com sucesso, " + "o número " + numero + " foi encontrado no índice " + medio);
                    break;
                }
            }
        }
    }
}