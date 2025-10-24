namespace LeetCode.Medium.Intervals;

// points = [[10,16], [2,8], [1,6], [7,12]]
/*
A: [1--------6]
B:   [2------------8]
C:              [7----------12]
D:                   [10-------------16]
 */

public class Solution2
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0)
            return 0;
        
        // 0. Сортировка по правому концу (xend)
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        
        var arrows = 1;                  // хотя бы одна стрела нужна
        var lastEnd = points[0][1];
        
        // 1. Проходим по всем остальным
        for (var i = 1; i < points.Length; i++)
        {
            var start = points[i][0];
            var end = points[i][1];
            
            // 2. Если шарик начинается после последней стрелы — нужна новая
            if (start > lastEnd)
            {
                arrows++;
                lastEnd = end;
            }
            // иначе — текущая стрела уже лопает этот шар
        }
        
        return arrows;
    }
}

// 0) Sort points by end asc
// 1) result = 0, lastEnd = -INF
// 2) for p in points:
// 3)   if (p.start <= lastEnd) 
// 4)       continue            // текущая стрела уже лопнет p
// 5)   else
// 6)       result++            // нужна новая стрела
// 7)       lastEnd = p.end     // ставим стрелу в конец p
// 8) return result
