namespace LeetCode.Medium.SlidingWindow;

/// <summary>
/// 1004. Max Consecutive Ones III
/// Условие: можно заменить до k нулей на единицы. Найти максимальную длину окна из единиц.
///
/// Подход (скользящее окно):
/// 1. Используем два указателя: left и right.
/// 2. Подсчитываем количество нулей в текущем окне.
/// 3. Расширяем окно вправо (right++).
/// 4. Если нулей стало больше k → сдвигаем left, пока нулей не станет <= k.
/// 5. На каждом шаге обновляем максимальную длину окна.
///
/// Сложность:
/// - Время: O(n) — каждый элемент посещается максимум дважды
/// - Память: O(1) — только счётчики
///
/// Пример:
/// Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
/// Output: 6
/// Объяснение:
/// - Можно заменить два нуля на единицы.
/// - Самое длинное окно: [1,1,1,0,0,0,1,1,1,1] после замены двух нулей → длина 10
/// - Но с учётом ограничения k=2: окно [1,1,1,0,0,1,1,1,1] → длина 6
/// </summary>
public class Lc1004MaxConsecutiveOnesIII
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, zeros = 0, best = 0;
        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0) zeros++;
            while (zeros > k)
            {
                if (nums[left] == 0) zeros--;
                left++;
            }
            var length = right - left + 1;
            if (length > best) best = length;
        }
        return best;
    }
}


