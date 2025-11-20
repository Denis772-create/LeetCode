namespace LeetCode.Medium.Queues;

/// <summary>
/// 649. Dota2 Senate
/// Условие: в строке есть символы 'R' (Radiant) и 'D' (Dire). Игроки по очереди банят следующего противника.
/// Кто останется последним — победил.
///
/// Подход (две очереди):
/// 1. Создаём две очереди для индексов 'R' и 'D'.
/// 2. На каждом раунде сравниваем головы очередей:
///    - Игрок с меньшим индексом ходит первым и банит противника.
///    - Выживший игрок добавляется обратно в очередь с индексом +n (для следующего раунда).
/// 3. Продолжаем, пока одна из очередей не опустеет.
///
/// Сложность:
/// - Время: O(n) — каждый игрок обрабатывается максимум один раз
/// - Память: O(n) — для двух очередей
///
/// Пример:
/// Input: senate = "RDD"
/// Output: "Dire"
/// Объяснение:
/// - Раунд 1: R (индекс 0) банит D (индекс 1), D (индекс 2) банит R (индекс 0)
/// - Остаётся D (индекс 2) → Dire побеждает
/// </summary>
public class Lc0649Dota2Senate
{
    public string PredictPartyVictory(string senate)
    {
        var n = senate.Length;
        var r = new Queue<int>();
        var d = new Queue<int>();
        for (var i = 0; i < n; i++)
        {
            if (senate[i] == 'R') r.Enqueue(i); else d.Enqueue(i);
        }
        while (r.Count > 0 && d.Count > 0)
        {
            var ri = r.Dequeue();
            var di = d.Dequeue();
            if (ri < di) r.Enqueue(ri + n); else d.Enqueue(di + n);
        }
        return r.Count > 0 ? "Radiant" : "Dire";
    }
}


