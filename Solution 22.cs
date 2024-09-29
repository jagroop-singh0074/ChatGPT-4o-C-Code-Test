using System;

public class Solution {
    public int MaxValue(int[] nums, int k) {
        int n = nums.Length;
        int maxVal = 0;

        // Loop through all subsequences of length 2 * k
        for (int i = 0; i <= n - 2 * k; i++) {
            for (int j = i + k; j <= n - k; j++) {
                // OR the first half (from i to i + k - 1)
                int firstHalf = 0;
                for (int x = i; x < i + k; x++) {
                    firstHalf |= nums[x];
                }

                // OR the second half (from j to j + k - 1)
                int secondHalf = 0;
                for (int x = j; x < j + k; x++) {
                    secondHalf |= nums[x];
                }

                // XOR both halves
                int currentVal = firstHalf ^ secondHalf;
                maxVal = Math.Max(maxVal, currentVal);
            }
        }

        return maxVal;
    }
}
