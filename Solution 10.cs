public class Solution {
    public void MoveZeroes(int[] nums) {
        int insertPos = 0;
        
        // Iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                // Move the non-zero element to the `insertPos`
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }
        
        // Fill the rest of the array with zeros
        while (insertPos < nums.Length) {
            nums[insertPos] = 0;
            insertPos++;
        }
    }
}

// Example usage
int[] nums = {0, 1, 0, 3, 12};
Solution sol = new Solution();
sol.MoveZeroes(nums);
Console.WriteLine(string.Join(", ", nums));  // Output: [1, 3, 12, 0, 0]
