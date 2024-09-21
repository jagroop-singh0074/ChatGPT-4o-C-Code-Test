public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int maxLength = 0;
        int zeroCount = 0;
        
        for (int right = 0; right < nums.Length; right++) {
            // If we encounter a 0, increment the zero count
            if (nums[right] == 0) {
                zeroCount++;
            }
            
            // If the zero count exceeds k, move the left pointer to reduce the window size
            while (zeroCount > k) {
                if (nums[left] == 0) {
                    zeroCount--;
                }
                left++;
            }
            
            // Update the maximum length
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return maxLength;
    }
}

// Example usage
int[] nums = {1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0};
int k = 2;
Solution sol = new Solution();
Console.WriteLine(sol.LongestOnes(nums, k));  // Output: 6
