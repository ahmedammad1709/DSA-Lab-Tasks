namespace SortingAlgorithms
{
    internal class MergeSort
    {
        public void sort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m+1, r);
                merge(arr, l, m, r);
            }
        }
        private void merge(int[] arr, int l, int m, int r)
        {
            //find sizes of two subarrays to merge
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;
            //copy data to temp arrays
            //Left Array
            for(i =0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            //Right Array
            for(j =0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0; j = 0;

            int k = l;

            while(i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            //Copy Remaining elements of L
            while(i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            //Copy Remainng elements of R
            while(j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}

static void Main(string[] args)
{
    int[] arr = { 12, 22, 8, 17, 5, 6 , 45, 11, 20};

    Console.WriteLine("---Array Before Sorting---");
    print(arr);
    MergeSort mergeSort = new MergeSort();
    mergeSort.sort(arr, 0, arr.Length - 1);
    Console.WriteLine("\n---Array after Sorting---");
    print(arr);

    Console.ReadLine();
}

public static void print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

