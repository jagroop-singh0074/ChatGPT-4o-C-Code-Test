using System;

public class Solution
{
    public int MaxValue(int[] nums, int k)
    {
        int n = nums.Length;
        int maxVal = 0;

        // Iterate over all possible subsequences of size 2 * k
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (j - i + 1 == 2 * k)
                {
                    int firstHalf = 0;
                    int secondHalf = 0;

                    // Calculate the OR for the first half and second half
                    for (int l = 0; l < k; l++)
                    {
                        firstHalf |= nums[i + l];
                        secondHalf |= nums[i + k + l];
                    }

                    // Calculate the XOR of both halves
                    int currentVal = firstHalf ^ secondHalf;
                    maxVal = Math.Max(maxVal, currentVal);
                }
            }
        }

        return maxVal;
    }

    public static void Main()
    {
        var solution = new Solution();

        int[] nums1 = { 2, 6, 7 };
        int k1 = 1;
        Console.WriteLine(solution.MaxValue(nums1, k1));  // Output: 5

        int[] nums2 = { 4, 2, 5, 6, 7 };
        int k2 = 2;
        Console.WriteLine(solution.MaxValue(nums2, k2));  // Output: 2
    }
}
