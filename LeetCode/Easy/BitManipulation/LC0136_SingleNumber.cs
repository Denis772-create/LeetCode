namespace LeetCode.Easy.BitManipulation;

/// <summary>
/// 136. Single Number
/// Условие: в массиве все числа встречаются дважды, кроме одного. Найти его.
///
/// Подход (XOR):
/// 1. Используем свойство XOR: a ^ a = 0, a ^ 0 = a.
/// 2. XOR всех чисел: пары обнуляются (a ^ a = 0), остаётся одиночное число.
///
/// Сложность:
/// - Время: O(n) — один проход по массиву
/// - Память: O(1) — только одна переменная
///
/// Пример 1:
/// Input: nums = [2,2,1]
/// Output: 1
/// Объяснение: 2 ^ 2 ^ 1 = 0 ^ 1 = 1
///
/// Пример 2:
/// Input: nums = [4,1,2,1,2]
/// Output: 4
/// Объяснение: 4 ^ 1 ^ 2 ^ 1 ^ 2 = 4 ^ (1 ^ 1) ^ (2 ^ 2) = 4 ^ 0 ^ 0 = 4
/// </summary>
public class Lc0136SingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
            result ^= num;
        return result;
    }
}


