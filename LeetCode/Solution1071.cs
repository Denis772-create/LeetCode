namespace LeetCode;

internal class Solution1071
{
    public string GcdOfStrings(string str1, string str2)
    {
        //check if concatenation of two strings is the same
        if (!(str1 + str2).Equals(str2 + str1)) return "";
        //gcd of length of two string;
        int gcdlength = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdlength);
    }
    public static int gcd(int x, int y)
    {
        return y == 0 ? x : gcd(y, x % y);
    }
}