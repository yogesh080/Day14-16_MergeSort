namespace day14_16_mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 8,75,9,79,54,30,51 };
            MergeSort(a, 0, a.Length-1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");

            }
            Console.ReadLine();
        }

        public static void MergeSort(int[]a, int l, int r)
        {
            if (l<r)
            {
                int m = l+(r-1)/2 +1;
                MergeSort(a, l, m-1);
                MergeSort(a, m, r);
                Merge(a, l, m, r);
            }
        }
        private static void Merge(int[] a,int l, int m , int r)
        {
            int i ,j, k ;
            int larrlength = m-1, rarrlength = r-m+1;
            int[] left = new int[larrlength];
            int[] right = new int[rarrlength];
            for (i = 0; i < larrlength; i++)
            {
                left[i] = a[l+i];
                
            }
            for(i = 0; i < rarrlength; i++)
            {
                right[i] = a[m+i];
            }
            i = 0;j = 0;k=1;

            while(i< larrlength && j< rarrlength) { 
                if (left[i] <= right[j])
                {
                    a[k++] = left[i++];

                }
                else
                {
                    a[k++] = right[j++];
                }
            }
            if (i==larrlength)
            {
                for (int ii = j; ii<rarrlength; ii++)
                {
                    a[k++]=right[ii];
                }
            }
            if (j==rarrlength)
            {
                for (int ii = j; ii<larrlength; ii++)
                {
                    a[k++]=left[ii];
                }
            }



        }
    }
}