namespace aula.sorting
{
    public static class BubbleSort
    {
        public static int[] BubbleSorting(int[] elementos)
        {
            int temp;
            for (int pass = 1; pass <= elementos.Length - 1; pass++)
            {
                for (int i = 0; i <= elementos.Length - 2; i++)
                {
                    if (elementos[i] > elementos[i + 1])
                    {
                        temp = elementos[i + 1];
                        elementos[i + 1] = elementos[i];
                        elementos[i] = temp;
                    }
                }
            }

            return elementos;
        }
    }
}