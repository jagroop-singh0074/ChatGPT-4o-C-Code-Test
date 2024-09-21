public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        char[] sArray = s.ToCharArray();  // Convert string to character array
        int left = 0, right = sArray.Length - 1;
        
        while (left < right) {
            if (vowels.Contains(sArray[left]) && vowels.Contains(sArray[right])) {
                // Swap the vowels
                char temp = sArray[left];
                sArray[left] = sArray[right];
                sArray[right] = temp;
                left++;
                right--;
            }
            if (!vowels.Contains(sArray[left])) {
                left++;
            }
            if (!vowels.Contains(sArray[right])) {
                right--;
            }
        }
        
        return new string(sArray);  // Convert character array back to string
    }
}

// Example usage
string s = "hello";
Solution sol = new Solution();
Console.WriteLine(sol.ReverseVowels(s));  // Output: "holle"
