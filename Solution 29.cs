public class Solution {
    public bool IsPalindrome(int x) {
        // Negative numbers are not palindromes
        if (x < 0) {
            return false;
        }

        // Store the original number
        int original = x;
        int reversed = 0;

        // Reverse the integer
        while (x > 0) {
            int lastDigit = x % 10;
            reversed = reversed * 10 + lastDigit;
            x /= 10;
        }

        // Check if the reversed number is equal to the original
        return original == reversed;
    }
}
