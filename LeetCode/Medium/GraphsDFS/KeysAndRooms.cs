namespace LeetCode.Medium.GraphsDFS;

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
