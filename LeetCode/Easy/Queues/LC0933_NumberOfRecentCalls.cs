namespace LeetCode.Easy.Queues;

/// <summary>
/// 933. Number of Recent Calls
/// Условие: реализовать RecentCounter.Ping(t), который возвращает количество вызовов в интервале [t-3000, t].
///
/// Подход (очередь):
/// 1. Используем очередь для хранения времён вызовов.
/// 2. При вызове Ping(t):
///    - Добавляем t в очередь.
///    - Удаляем все элементы < t - 3000 (они вне окна).
///    - Возвращаем размер очереди.
///
/// Сложность:
/// - Время: амортизированно O(1) на вызов Ping
/// - Память: O(k), где k — число элементов в окне 3000 мс
///
/// Пример:
/// Input:
///     RecentCounter counter = new RecentCounter();
///     counter.Ping(1);    // возвращает 1 (вызовы: [1])
///     counter.Ping(100);  // возвращает 2 (вызовы: [1, 100])
///     counter.Ping(3001); // возвращает 3 (вызовы: [1, 100, 3001])
///     counter.Ping(3002); // возвращает 3 (вызовы: [100, 3001, 3002], 1 удалён)
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


