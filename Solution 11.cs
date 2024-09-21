public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        
        while (left < right) {
            // Calculate the area with the current pair of lines
            int width = right - left;
            int area = width * Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, area);
            
            // Move the pointer pointing to the shorter line
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }
        
        return maxArea;
    }
}

// Example usage
int[] height = {1, 8, 6, 2, 5, 4, 8, 3, 7};
Solution sol = new Solution();
Console.WriteLine(sol.MaxArea(height));  // Output: 49
