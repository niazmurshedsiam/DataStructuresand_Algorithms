class BinerySearch
{
    static void Main(string[] args)
    {
        int[] array = { 5, 7, 9, 12, 15, 20, 24, 27, 33, 40, 50, 65, 74 };
        int target = 33;
        int index = Binery_Search(array, target);
        if(index != -1)
        {
            Console.WriteLine($"{target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"{target} not found in the array.");
        }
    }

        static int Binery_Search(int[] arr, int target)
    {
        int n = arr.Length;
        int l = 0, r = n - 1, mid;
        while(l<=r)
        {
            mid = (l+r)/2;
            if(target == arr[mid])
            {
                return mid;

            }
            else if(target > arr[mid]) {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return -1;
    }


}
