public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        
        // Compute the prefix product for each element
        int prefix = 1;
        for (int i = 0; i < n; i++) {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        
        // Compute the suffix product and multiply it with the prefix product
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--) {
            answer[i] *= suffix;
            suffix *= nums[i];
        }
        
        return answer;
    }
}

// Example usage
int[] nums = {1, 2, 3, 4};
Solution sol = new Solution();
int[] result = sol.ProductExceptSelf(nums);
Console.WriteLine(string.Join(", ", result));  // Output: 24, 12, 8, 6
