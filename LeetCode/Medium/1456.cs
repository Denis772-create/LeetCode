namespace LeetCode.Medium;

public class _1456
{
    public int MaxVowels(string s, int k)
    {
        bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        int maxVowels = 0;
        int currentVowels = 0;

        for (int i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
            {
                currentVowels++;
            }
        }
        maxVowels = currentVowels;

        for (int i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k]))
            {
                currentVowels--;
            }

            if (IsVowel(s[i]))
            {
                currentVowels++;
            }
            maxVowels = Math.Max(maxVowels, currentVowels);
        }

        return maxVowels;
    }
}
