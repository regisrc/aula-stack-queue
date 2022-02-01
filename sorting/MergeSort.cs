namespace aula.sorting
{
    public static class MergeSort
    {
        public static void DoMerge(int[] numeros, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elementos, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elementos = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numeros[left] <= numeros[mid])
                    temp[tmp_pos++] = numeros[left++];
                else
                    temp[tmp_pos++] = numeros[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numeros[left++];

            while (mid <= right)
                temp[tmp_pos++] = numeros[mid++];

            for (i = 0; i < num_elementos; i++)
            {
                numeros[right] = temp[right];
                right--;
            }
        }

        public static int[] MergeSort_Recursive(int[] numeros, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numeros, left, mid);
                MergeSort_Recursive(numeros, (mid + 1), right);

                DoMerge(numeros, left, (mid + 1), right);
            }

            return numeros;
        }
    }
}