using System;
using System.Linq;

public class Solution
{
    public int StrongPasswordChecker(string password)
    {
        int n = password.Length;
        
        // Check for missing types of characters
        bool hasLower = password.Any(char.IsLower);
        bool hasUpper = password.Any(char.IsUpper);
        bool hasDigit = password.Any(char.IsDigit);
        int missingTypes = 3 - (Convert.ToInt32(hasLower) + Convert.ToInt32(hasUpper) + Convert.ToInt32(hasDigit));

        // Find sequences of 3 or more repeating characters
        int replace = 0;
        for (int i = 2; i < n;)
        {
            if (password[i] == password[i - 1] && password[i] == password[i - 2])
            {
                int length = 2;
                while (i < n && password[i] == password[i - 1])
                {
                    length++;
                    i++;
                }
                replace += length / 3;
            }
            else
            {
                i++;
            }
        }

        if (n < 6)
        {
            return Math.Max(missingTypes, 6 - n);
        }
        else if (n <= 20)
        {
            return Math.Max(missingTypes, replace);
        }
        else
        {
            // Over length of 20, we need to delete characters
            int delete = n - 20;
            replace -= Math.Min(delete, replace);
            return delete + Math.Max(missingTypes, replace);
        }
    }

    public static void Main()
    {
        var solution = new Solution();
        Console.WriteLine(solution.StrongPasswordChecker("a"));          // Output: 5
        Console.WriteLine(solution.StrongPasswordChecker("aA1"));        // Output: 3
        Console.WriteLine(solution.StrongPasswordChecker("1337C0d3"));   // Output: 0
    }
}
