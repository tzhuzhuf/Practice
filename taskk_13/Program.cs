class Program
{
    static int[] BubbleSort(int[] nums)
    {
        int temp;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
    static int[] SelectionSort(int[] nums2)
    {
        for (int i = 0; i < nums2.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < nums2.Length; j++)
            {
                if (nums2[i] < nums2[j])
                    maxIndex = j;
            }
            int temp = nums2[i];
            nums2[i] = nums2[maxIndex];
            nums2[maxIndex] = temp;
        }
        return nums2;
    }
    static void Main()
    {
        int[] nums = { 53, 4, 2432, 44, 432 };

        BubbleSort(nums);
        foreach(int i in nums)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        int[] nums2 = { 24, 23, 432, 4, 3 };

        SelectionSort(nums2);
        foreach(int i in nums2)
        {
            Console.Write(i + " ");
        }
    }
}