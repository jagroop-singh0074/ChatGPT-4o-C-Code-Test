public class Solution {
    public int LongestSubarray(int[] nums) {
        int maxLen = 0;
        int left = 0;
        int zeroCount = 0;

        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                zeroCount++;
            }

            // If more than one zero is encountered, move the left pointer
            while (zeroCount > 1) {
                if (nums[left] == 0) {
                    zeroCount--;
                }
                left++;
            }

            // Calculate the length of the current window, excluding one zero
            maxLen = Math.Max(maxLen, right - left);
        }

        return maxLen;
    }
}

// Example usage
int[] nums = {1, 1, 0, 1};
Solution sol = new Solution();
Console.WriteLine(sol.LongestSubarray(nums));  // Output: 3
