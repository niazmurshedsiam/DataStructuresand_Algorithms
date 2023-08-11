class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Orginal Array");
        ArraySort(array);
        BubbleSortAlgorithom(array);
        Console.WriteLine("Sorted Array");
        ArraySort(array);
    }

    static void BubbleSortAlgorithom(int[] arr)
    {
          int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Last i elements are already in place, no need to compare
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void ArraySort(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}



