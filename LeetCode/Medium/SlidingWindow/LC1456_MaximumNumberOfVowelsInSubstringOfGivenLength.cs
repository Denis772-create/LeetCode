namespace LeetCode.Medium.SlidingWindow;

/// <summary>
/// 1456. Maximum Number of Vowels in a Substring of Given Length
/// Условие: найти максимум гласных в любом подстроке длины k.
///
/// Подход (скользящее окно): поддерживаем кол-во гласных в окне длины k.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc1456MaximumNumberOfVowelsInSubstringOfGivenLength
{
    public int MaxVowels(string s, int k)
    {
        bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        int current = 0, best = 0;
        for (var i = 0; i < k; i++) if (IsVowel(s[i])) current++;
        best = current;
        for (var i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k])) current--;
            if (IsVowel(s[i])) current++;
            if (current > best) best = current;
        }
        return best;
    }
}


