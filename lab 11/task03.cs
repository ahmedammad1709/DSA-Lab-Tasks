internal class QuickSort
{
    public void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);

            quickSort(arr, low, pi);
            quickSort(arr, pi + 1, high);
        }
    }

    private int partition(int[] arr, int low, int high)
    {
        int pivot = arr[low];   // FIRST element
        int i = low - 1;
        int j = high + 1;

        while (true)
        {
            do
            {
                i++;
            }while (arr[i] < pivot);

            do
            {
                j--;
            }
            while (arr[j] > pivot);

            if (i >= j)
                return j;

            swap(arr, i, j);
        }
    }
    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
static void Main(string[] args)
{
    int[] arr = { 12, 22, 8, 17, 5, 6 , 45, 11, 20, 55, 01};

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
