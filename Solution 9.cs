public class Solution {
    public int Compress(char[] chars) {
        int write = 0;  // Write index
        int read = 0;  // Read index
        
        while (read < chars.Length) {
            char currentChar = chars[read];
            int count = 0;
            
            // Count the occurrences of the current character
            while (read < chars.Length && chars[read] == currentChar) {
                read++;
                count++;
            }
            
            // Write the character to the array
            chars[write] = currentChar;
            write++;
            
            // If the count is greater than 1, write the count as well
            if (count > 1) {
                foreach (char c in count.ToString()) {
                    chars[write] = c;
                    write++;
                }
            }
        }
        
        return write;
    }
}

// Example usage
char[] chars = new char[] {'a', 'a', 'b', 'b', 'c', 'c', 'c'};
Solution sol = new Solution();
int newLength = sol.Compress(chars);
Console.WriteLine(newLength);  // Output: 6
Console.WriteLine(new string(chars, 0, newLength));  // Output: "a2b2c3"
