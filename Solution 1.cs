public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder merged = new StringBuilder();
        int i = 0, j = 0;
        
        while (i < word1.Length || j < word2.Length) {
            if (i < word1.Length) {
                merged.Append(word1[i]);
                i++;
            }
            if (j < word2.Length) {
                merged.Append(word2[j]);
                j++;
            }
        }
        
        return merged.ToString();
    }
}

// Example usage
string word1 = "abc";
string word2 = "pqr";
Solution sol = new Solution();
Console.WriteLine(sol.MergeAlternately(word1, word2));  // Output: "apbqcr"
