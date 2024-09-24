using System;
using System.Linq;

public class Solution
{
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        const int MOD = 1000000007;

        for (int i = 0; i < k; i++)
        {
            // Find the index of the first occurrence of the minimum value
            int minIndex = Array.IndexOf(nums, nums.Min());
            // Replace the minimum value with its multiplied value
            nums[minIndex] *= multiplier;
        }

        // Apply modulo 10^9 + 7 to all elements in the array
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] %= MOD;
        }

        return nums;
    }
    
    public static void Main()
    {
        var solution = new Solution();
        
        int[] nums1 = { 2, 1, 3, 5, 6 };
        int k1 = 5;
        int multiplier1 = 2;
        Console.WriteLine(string.Join(", ", solution.GetFinalState(nums1, k1, multiplier1))); // Output: [8, 4, 6, 5, 6]

        int[] nums2 = { 100000, 2000 };
        int k2 = 2;
        int multiplier2 = 1000000;
        Console.WriteLine(string.Join(", ", solution.GetFinalState(nums2, k2, multiplier2))); // Output: [999999307, 999999993]
    }
}
