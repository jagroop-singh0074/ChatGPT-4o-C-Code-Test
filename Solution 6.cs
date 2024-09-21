public class Solution {
    public string ReverseWords(string s) {
        // Split the string into words by spaces and remove extra spaces
        string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        // Reverse the array of words
        Array.Reverse(words);
        // Join the words back into a single string with a space separator
        return string.Join(" ", words);
    }
}

// Example usage
string s = "the sky is blue";
Solution sol = new Solution();
Console.WriteLine(sol.ReverseWords(s));  // Output: "blue is sky the"
