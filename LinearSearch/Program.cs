class LinearSearch
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        int target = 22;
        int index = Linear_Search(array, target);
        if(index != 1)
        {
            Console.WriteLine($"{target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"{target} not found in the array.");
        }
    }

        static int Linear_Search(int[] arr,int target)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }

        }
        return -1;
    }
}

//class LinearSearch
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
//        int target = 22;
//        int index = Linear_Search(array, target);
//        if (index != -1)
//        {
//            Console.WriteLine($"{target} found at index {index}.");
//        }
//        else
//        {
//            Console.WriteLine($"{target} not found in the array.");
//        }
//    }

//    static int Linear_Search(int[] arr, int target)
//    {
//        int n = arr.Length;
//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] == target)
//            {
//                return i;
//            }
//        }

//        return -1;
//    }
//}
