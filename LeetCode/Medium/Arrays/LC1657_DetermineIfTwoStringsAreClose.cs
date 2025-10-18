namespace LeetCode.Medium.Arrays;

/// <summary>
/// 1657. Determine if Two Strings Are Close
/// Условие: две строки «близки», если можно переставлять символы и переставлять частоты символов.
///
/// Подход: одинаковые множества символов и одинаковые мультипликативные наборы частот (после сортировки).
///
/// Сложность:
/// - Время: O(n log n)
/// - Память: O(1) по алфавиту, либо O(k)
/// </summary>
public class Lc1657DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;
        var set1 = new HashSet<char>(word1);
        var set2 = new HashSet<char>(word2);
        if (!set1.SetEquals(set2)) return false;

        var freq1 = Count(word1);
        var freq2 = Count(word2);
        freq1.Sort();
        freq2.Sort();
        if (freq1.Count != freq2.Count) return false;
        for (int i = 0; i < freq1.Count; i++) if (freq1[i] != freq2[i]) return false;
        return true;
    }

    private static List<int> Count(string s)
    {
        var map = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!map.TryAdd(c, 1)) map[c]++;
        }
        return map.Values.ToList();
    }
}


