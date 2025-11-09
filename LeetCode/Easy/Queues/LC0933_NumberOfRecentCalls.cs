namespace LeetCode.Easy.Queues;

/// <summary>
/// 933. Number of Recent Calls
/// Условие: реализовать RecentCounter.Ping(t), который возвращает количество вызовов в [t-3000, t].
///
/// Подход: очередь с временами; добавляем t, затем выбрасываем все, что меньше t-3000.
///
/// Сложность:
/// - Время: амортизированно O(1) на вызов
/// - Память: O(k) — число элементов в 3000мс окне
/// </summary>
public class Lc0933NumberOfRecentCalls
{
    private readonly Queue<int> _queue = new();

    public int Ping(int t)
    {
        // 1️⃣ Добавляем текущее время вызова
        _queue.Enqueue(t);

        // 2️⃣ Удаляем все вызовы, которые старше 3000 мс
        var left = t - 3000;
        while (_queue.Count > 0 && _queue.Peek() < left)
        {
            _queue.Dequeue();
        }

        // 3️⃣ Количество оставшихся вызовов — ответ
        return _queue.Count;
    }
}


