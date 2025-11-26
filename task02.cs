namespace SortingAlgorithms
{
    internal class QuickSort
    {
        public void quickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = partition(arr, low, high);

                quickSort(arr , low, pi-1);
                quickSort(arr, pi + 1, high);
            }
        }

        private int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;


            for (int j = low; j <= high -1; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    swap(arr, i , j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }


        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

 static void Main(string[] args)
 {
     int[] arr = { 12, 22, 8, 17, 5, 6 , 45, 11, 20};

     Console.WriteLine("---Array Before Sorting---");
     print(arr);

     QuickSort sort = new QuickSort();
     sort.quickSort(arr, 0, arr.Length - 1);
     Console.WriteLine("\n\n---Array after Quick Sort---");
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
