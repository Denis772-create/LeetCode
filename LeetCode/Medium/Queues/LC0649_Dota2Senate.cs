namespace LeetCode.Medium.Queues;

/// <summary>
/// 649. Dota2 Senate
/// Условие: строки из 'R' и 'D'. Игроки по очереди банят противника; кто останется — победил.
///
/// Подход: две очереди индексов R и D. Сравниваем головы; меньший индекс ходит и добавляет +n в свою очередь.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n)
/// </summary>
public class Lc0649Dota2Senate
{
    public string PredictPartyVictory(string senate)
    {
        int n = senate.Length;
        var r = new Queue<int>();
        var d = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (senate[i] == 'R') r.Enqueue(i); else d.Enqueue(i);
        }
        while (r.Count > 0 && d.Count > 0)
        {
            int ri = r.Dequeue();
            int di = d.Dequeue();
            if (ri < di) r.Enqueue(ri + n); else d.Enqueue(di + n);
        }
        return r.Count > 0 ? "Radiant" : "Dire";
    }
}


