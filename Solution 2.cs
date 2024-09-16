public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // Check if concatenation of the strings in both orders is the same
        if ((str1 + str2) != (str2 + str1)) {
            return "";
        }
        
        // Find the greatest common divisor of the lengths of the strings
        int Gcd(int a, int b) {
            while (b != 0) {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
        // The GCD of the lengths will give us the length of the largest common divisor string
        int gcdLength = Gcd(str1.Length, str2.Length);
        
        return str1.Substring(0, gcdLength);
    }
}

// Example usage
string str1 = "ABCABC";
string str2 = "ABC";
Solution sol = new Solution();
Console.WriteLine(sol.GcdOfStrings(str1, str2));  // Output: "ABC"
