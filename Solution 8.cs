public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue;
        int second = int.MaxValue;
        
        foreach (int num in nums) {
            if (num <= first) {
                first = num;
            } else if (num <= second) {
                second = num;
            } else {
                return true;
            }
        }
        
        return false;
    }
}

// Example usage
int[] nums = {2, 1, 5, 0, 4, 6};
Solution sol = new Solution();
bool result = sol.IncreasingTriplet(nums);
Console.WriteLine(result);  // Output: True
