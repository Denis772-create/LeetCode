namespace LeetCode.Medium.GraphsDFS;

/// <summary>
/// 841. Keys and Rooms
/// 
/// Условие:
/// Даны несколько комнат, каждая из которых содержит список ключей от других комнат.
/// Изначально открыта только комната 0.
/// Нужно определить, можно ли посетить все комнаты, начиная с 0.
///
/// Подход (DFS):
/// 1️⃣ Используем глубинный поиск (Depth-First Search).
/// 2️⃣ Создаём массив visited[] для отслеживания посещённых комнат.
/// 3️⃣ Рекурсивно обходим все комнаты, в которые есть ключ.
/// 4️⃣ Если после обхода visitedCount == rooms.Count → значит все комнаты открыты.
///
/// Сложность:
/// - Время: O(n + e), где n — количество комнат, e — количество ключей.
/// - Память: O(n) из-за рекурсии и массива visited.
///
/// Пример:
/// rooms = [[1],[2],[3],[]]
/// - Из комнаты 0 берём ключ в 1
/// - Из 1 берём ключ в 2
/// - Из 2 берём ключ в 3
/// 🎯 Все комнаты открыты → true
/// </summary>
public class Solution 
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms) 
    {
        var visited = new bool[rooms.Count];
        var visitedCount = 0;

        // Запускаем рекурсивный DFS из комнаты 0
        DFS(0, rooms, visited, ref visitedCount);

        // Если побывали во всех комнатах — true
        return visitedCount == rooms.Count;
    }

    private void DFS(int room, IList<IList<int>> rooms, bool[] visited, ref int visitedCount)
    {
        // Если уже были в этой комнате — просто выходим
        if (visited[room]) return;

        // Помечаем комнату как посещённую
        visited[room] = true;
        visitedCount++;

        // Проходим по всем ключам из этой комнаты
        foreach (var key in rooms[room])
        {
            DFS(key, rooms, visited, ref visitedCount);
        }
    }
}