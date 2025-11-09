namespace LeetCode.Medium.HashMap;

/// <summary>
/// 2352. Equal Row and Column Pairs
///
/// 📘 Условие:
/// Дана квадратная матрица grid размером n x n.
/// Нужно посчитать количество пар (ri, cj),
/// таких что строка ri полностью совпадает со столбцом cj.
///
/// 🧠 Подход (HashMap):
/// 1️⃣ Проходим по всем строкам и сохраняем их в словарь:
///     - ключ: строка, склеенная через запятую (например, "3,1,2,2")
///     - значение: сколько раз такая строка встречается.
/// 2️⃣ Затем проходим по каждому столбцу, формируем такую же строку.
/// 3️⃣ Если этот столбец есть в словаре строк — добавляем к ответу количество совпадений.
/// 
/// ⏱ Сложность:
/// - Время: O(n²) — обходим все строки и все столбцы.
/// - Память: O(n²) — храним все строки в словаре.
///
/// 📊 Пример:
/// grid = [
///   [3,1,2,2],
///   [1,4,4,5],
///   [2,4,2,2],
///   [2,4,2,2]
/// ]
/// 🎯 Ответ: 3
/// Совпадения:
/// (Row 0, Col 0), (Row 2, Col 2), (Row 3, Col 2)
/// </summary>
public class Solution 
{
    public int EqualPairs(int[][] grid)
    {
        var n = grid.Length;
        var rowMap = new Dictionary<string, int>();

        // 1️⃣ Сохраняем все строки в словарь
        for (var i = 0; i < n; i++)
        {
            var rowKey = string.Join(",", grid[i]);
            if (rowMap.TryGetValue(rowKey, out var count))
                rowMap[rowKey] = count + 1;
            else
                rowMap[rowKey] = 1;
        }

        var result = 0;

        // 2️⃣ Проверяем каждый столбец
        for (var j = 0; j < n; j++)
        {
            var col = new int[n];
            for (var i = 0; i < n; i++)
                col[i] = grid[i][j];

            var colKey = string.Join(",", col);

            // 3️⃣ Если столбец совпадает со строкой — добавляем количество
            if (rowMap.TryGetValue(colKey, out var count))
                result += count;
        }

        return result;
    }
}