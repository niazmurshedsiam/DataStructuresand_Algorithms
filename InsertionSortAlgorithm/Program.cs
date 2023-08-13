class InsertionSortAlgorithm
{
    static void Main(string[] args)
    {
        int[] array = {43, 34, 26, 29, 12};
        Console.WriteLine("orginal Array");
        ArraySort(array);
        Console.WriteLine("Sorted Array");
        insertionSortAlgorithm(array);
        ArraySort(array);
    }

    static void insertionSortAlgorithm(int [] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
           int temp = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > temp) {
                arr[j + 1] = arr[j];
                j--;
            
            }
            arr[j+1] = temp;

        }
    }

    static void ArraySort(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " " );
        }
        Console.WriteLine();
    }
}
