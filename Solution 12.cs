public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // Calculate the sum of the first 'k' elements
        int maxSum = 0;
        for (int i = 0; i < k; i++) {
            maxSum += nums[i];
        }
        
        int currentSum = maxSum;
        
        // Iterate through the array starting from the k-th element
        for (int i = k; i < nums.Length; i++) {
            // Update the sum by sliding the window
            currentSum += nums[i] - nums[i - k];
            // Update the maxSum if the current sum is larger
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        // The maximum average is the maxSum divided by 'k'
        return (double)maxSum / k;
    }
}

// Example usage
int[] nums = {1, 12, -5, -6, 50, 3};
int k = 4;
Solution sol = new Solution();
Console.WriteLine(sol.FindMaxAverage(nums, k));  // Output: 12.75
