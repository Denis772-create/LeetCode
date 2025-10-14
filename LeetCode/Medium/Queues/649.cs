namespace LeetCode.Medium.Queues;

using System.Collections.Generic;

public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        int n = senate.Length;
        var r = new Queue<int>();
        var d = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            if (senate[i] == 'R') r.Enqueue(i);
            else d.Enqueue(i);
        }

        while (r.Count > 0 && d.Count > 0)
        {
            int ri = r.Dequeue();
            int di = d.Dequeue();

            if (ri < di)
                r.Enqueue(ri + n); // Radiant ходит раньше и банит Dire
            else
                d.Enqueue(di + n); // Dire ходит раньше и банит Radiant
        }

        return r.Count > 0 ? "Radiant" : "Dire";
    }
}

/*
 * 1. RDD => chars queue
 * 2. перебираем очередь
 * 3. peek first -> peek next -> if next is D/R Dequeue
 * 4. continue while queue > 1 
 */