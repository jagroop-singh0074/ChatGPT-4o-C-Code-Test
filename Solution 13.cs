public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u'};
        int maxVowels = 0;
        int currentVowels = 0;
        
        // Calculate the number of vowels in the first window of size k
        for (int i = 0; i < k; i++) {
            if (vowels.Contains(s[i])) {
                currentVowels++;
            }
        }
        
        maxVowels = currentVowels;
        
        // Slide the window across the string and update the number of vowels
        for (int i = k; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {
                currentVowels++;
            }
            if (vowels.Contains(s[i - k])) {
                currentVowels--;
            }
            maxVowels = Math.Max(maxVowels, currentVowels);
        }
        
        return maxVowels;
    }
}

// Example usage
string s = "abciiidef";
int k = 3;
Solution sol = new Solution();
Console.WriteLine(sol.MaxVowels(s, k));  // Output: 3
