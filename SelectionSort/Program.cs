class SelectionSort
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Orginal Array");
        PrintArray(array);
        Console.WriteLine("Sorting Array");
        SelectionSortAlgorithom(array);
        PrintArray(array);
    }
    static void SelectionSortAlgorithom(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n-1; i++) {
            int min_index = i;
            for (int j = i+1; j < n; j++)
            {
                if (arr[j] < arr[min_index])
                {
                    min_index = j;
                }
            }

            if(min_index!= i)
            {
                int temp = arr[i];
                arr[i] = arr[min_index];
                arr[min_index] = temp;
            }
        }
    }
    static void PrintArray(int[]arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}