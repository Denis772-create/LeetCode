using System;

public class Solution4
{
    public int FindCircleNum(int[][] isConnected)
    {
        // Шаг 0: базовая инициализация
        int n = isConnected.Length;      // количество городов
        bool[] visited = new bool[n];    // массив посещённых городов
        int provinces = 0;               // счётчик провинций (компонент связности)

        // Шаг 1: проходим по всем городам 0..n-1
        for (int i = 0; i < n; i++)
        {
            // Если город ещё не посещён — это начало НОВОЙ провинции
            if (!visited[i])
            {
                provinces++;                 // фиксируем новую провинцию
                Dfs(i, isConnected, visited); // обходим всех, кто связан с i (напрямую/косвенно)
            }
        }

        // Шаг 2: когда все города обработаны — возвращаем число провинций
        return provinces;
    }

    // Обход в глубину от города 'start':
    // отмечаем ВСЕ города, достижимые из него (то есть всю одну провинцию)
    private void Dfs(int start, int[][] isConnected, bool[] visited)
    {
        // Шаг A: пометили стартовый город как посещённый,
        // чтобы не заходить в него повторно и не зациклиться
        visited[start] = true;

        int n = isConnected.Length;

        // Шаг B: смотрим всю строку матрицы для 'start':
        // isConnected[start][j] == 1 значит "start соединён с j"
        for (int j = 0; j < n; j++)
        {
            // Важно: идём глубже ТОЛЬКО если:
            // 1) есть связь start—j (1 в матрице)
            // 2) город j ещё НЕ посещён
            if (isConnected[start][j] == 1 && !visited[j])
            {
                // Шаг C: углубляемся в j и повторяем процесс
                Dfs(j, isConnected, visited);
            }
        }
        // Когда цикл закончен, все города провинции 'start' помечены как посещённые.
        // Возврат в вызывающую функцию для продолжения внешнего цикла по i.
    }
}