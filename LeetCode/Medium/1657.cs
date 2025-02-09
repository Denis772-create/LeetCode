namespace LeetCode.Medium;

public class _1657
{
    public bool CloseStrings(string word1, string word2)
    {
        // Step 1: Check if the lengths of the strings are different
        if (word1.Length != word2.Length)
        {
            return false;
        }

        // Step 2: Check if both strings have the same set of characters
        var set1 = new HashSet<char>(word1);
        var set2 = new HashSet<char>(word2);

        if (!set1.SetEquals(set2))
        {
            return false;
        }

        // Step 3: Count the frequency of each character in both strings
        var freq1 = GetFrequency(word1);
        var freq2 = GetFrequency(word2);

        // Step 4: Compare the frequency distributions
        var freqList1 = freq1.Values.ToList();
        var freqList2 = freq2.Values.ToList();

        freqList1.Sort();
        freqList2.Sort();

        return freqList1.SequenceEqual(freqList2);
    }

    private Dictionary<char, int> GetFrequency(string word)
    {
        var freq = new Dictionary<char, int>();
        foreach (var c in word)
        {
            if (!freq.TryAdd(c, 1))
            {
                freq[c]++;
            }
        }

        return freq;
    }
}