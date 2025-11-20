namespace LeetCode.Easy.DynamicProgramming;

/// <summary>
/// 1137. N-th Tribonacci Number
/// Условие: вычислить n-е число Трибоначчи. T(0) = 0, T(1) = 1, T(2) = 1, T(n) = T(n-1) + T(n-2) + T(n-3).
///
/// Подход (динамическое программирование, оптимизация памяти):
/// 1. Базовые случаи: T(0) = 0, T(1) = 1, T(2) = 1.
/// 2. Для n >= 3: используем только три переменные (a, b, c) вместо массива.
/// 3. На каждой итерации: d = a + b + c, затем сдвигаем: a = b, b = c, c = d.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1) — только три переменные вместо массива
///
/// Пример:
/// Input: n = 4
/// Output: 4
/// Объяснение:
/// T(0) = 0
/// T(1) = 1
/// T(2) = 1
/// T(3) = T(2) + T(1) + T(0) = 1 + 1 + 0 = 2
/// T(4) = T(3) + T(2) + T(1) = 2 + 1 + 1 = 4
/// </summary>
public class Solution
{
    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1 or 2:
                return 1;
        }

        int a = 0, b = 1, c = 1;
        for (var i = 3; i <= n; i++)
        {
            var d = a + b + c;
            a = b;
            b = c;
            c = d;
        }
        return c;
    }
}