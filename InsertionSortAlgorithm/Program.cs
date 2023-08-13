class InsertionSortAlgorithm
{
    static void Main(string[] args)
    {
        int[] array = { 43, 31, 26, 29, 12 };
        Console.WriteLine("Orginal Array");
        ArraySort(array);
        Console.WriteLine("Sorted Array");
        Insertion_Sort_Algorithm(array);
        ArraySort(array);
    }
    static void Insertion_Sort_Algorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j>=0 && arr[j] > temp )
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j+1] = temp;
        }
    }
    static void ArraySort(int[] arr)
    {
        foreach (int num in arr) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}