namespace LeetCode.Easy.HashMap;

public class ContainsDuplicate2
{
    public bool ContainsDuplicate(int[] nums)
    {
        var seen = new HashSet<int>();

        foreach (int n in nums)
        {
            if (seen.Contains(n))
            {
                return true;  // нашли дубликат
            }
            seen.Add(n);
        }
        return false;
    }
}