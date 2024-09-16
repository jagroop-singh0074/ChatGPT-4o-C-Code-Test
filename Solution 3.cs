public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        // Find the maximum number of candies any kid currently has
        int maxCandies = candies.Max();
        
        // Create a list to store the result
        List<bool> result = new List<bool>();
        
        // Check if each kid with the extra candies would have the greatest number of candies
        foreach (int candy in candies) {
            result.Add(candy + extraCandies >= maxCandies);
        }
        
        return result;
    }
}

// Example usage
int[] candies = {2, 3, 5, 1, 3};
int extraCandies = 3;
Solution sol = new Solution();
IList<bool> result = sol.KidsWithCandies(candies, extraCandies);

// Output: [True, True, True, False, True]
foreach (bool res in result) {
    Console.WriteLine(res);
}
