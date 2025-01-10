namespace LeetCode.Easy;

internal class Solution392
{
    public static bool IsSubsequence(string s, string t)
    {
        int sIndex = 0, tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            tIndex++;
        }

        return sIndex == s.Length;
    }
}