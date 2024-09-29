using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create a dictionary to store the value and its index
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        // Iterate over the array
        for (int i = 0; i < nums.Length; i++) {
            // Calculate the complement
            int complement = target - nums[i];

            // If the complement exists in the dictionary, return the indices
            if (numMap.ContainsKey(complement)) {
                return new int[] { numMap[complement], i };
            }

            // Store the current number and its index in the dictionary
            numMap[nums[i]] = i;
        }

        // Since the problem guarantees that there is exactly one solution,
        // no need for a return here, this point will never be reached.
        throw new ArgumentException("No two sum solution exists");
    }
}
