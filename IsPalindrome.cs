using System;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        string s = x.ToString();
        string rev = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            rev += s[i];
        }
        return s == rev;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int x = 121;
        bool isPal = solution.IsPalindrome(x);
        Console.WriteLine($"{x} -> {isPal}");
        
        x = -121;
        isPal = solution.IsPalindrome(x);
        Console.WriteLine($"{x} → {isPal}");

    }
}