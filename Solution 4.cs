public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        int length = flowerbed.Length;
        
        for (int i = 0; i < length; i++) {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == length - 1 || flowerbed[i + 1] == 0)) {
                flowerbed[i] = 1;
                count++;
            }
            if (count >= n) {
                return true;
            }
        }
        
        return count >= n;
    }
}

// Example usage
int[] flowerbed = {1, 0, 0, 0, 1};
int n = 1;
Solution sol = new Solution();
Console.WriteLine(sol.CanPlaceFlowers(flowerbed, n));  // Output: True
