namespace aula.sorting
{
    public static class ShellSort
    {
        public static int[] ShellSorting(int[] elementos)
        {
            int n = elementos.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = elementos[j]; 

                    while (j - gap >= 0 && temp < elementos[j - gap]) 
                    {
                        elementos[j] = elementos[j - gap];
                        j = j - gap;
                    }

                    elementos[j] = temp;
                }
                gap = gap / 2;
            }
            return elementos;
        }
    }
}