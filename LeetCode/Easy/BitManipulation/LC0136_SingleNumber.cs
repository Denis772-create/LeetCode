namespace LeetCode.Easy.BitManipulation;

/// <summary>
/// 136. Single Number
/// Условие: в массиве все числа встречаются дважды, кроме одного. Найти его.
///
/// Подход: XOR всех чисел. Пары обнуляются, остаётся одиночное.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
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


