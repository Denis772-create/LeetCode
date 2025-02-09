namespace LeetCode.Easy;

public class _1207
{
    public bool UniqueOccurrences(int[] arr)
    {
        var countMap = new Dictionary<int, int>();

        foreach (var num in arr)
        {
            if (!countMap.TryAdd(num, 1))
            {
                countMap[num]++;
            }
        }

        var occurrenceSet = new HashSet<int>();

        return countMap.All(kvp => occurrenceSet.Add(kvp.Value));
    }
}