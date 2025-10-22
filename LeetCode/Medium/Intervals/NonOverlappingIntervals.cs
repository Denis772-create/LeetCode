namespace LeetCode.Medium.Intervals;

public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        if (intervals == null || intervals.Length <= 1) return 0;
        
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        
        // 2) жадно набираем максимум непересекающихся интервалов
        int taken = 0;
        int lastEnd = int.MinValue;

        foreach (var it in intervals)
        {
            int start = it[0], end = it[1];
            
            // "касаются" допустимо: start >= lastEnd
            if (start >= lastEnd)
            {
                taken++;
                lastEnd = end;
            }
        }
        
        // 3) минимум удалений = все - максимум оставленных
        return intervals.Length - taken;
    }
}