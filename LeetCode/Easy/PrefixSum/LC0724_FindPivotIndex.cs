namespace LeetCode.Easy.PrefixSum;

/// <summary>
/// 724. Find Pivot Index
/// Условие: найти индекс i, при котором сумма всех элементов слева от i
/// равна сумме всех элементов справа от i.
///
/// Подход (prefix sum):
/// 1. Считаем общую сумму total.
/// 2. Проходим по массиву, поддерживая leftSum — сумму элементов слева.
/// 3. Для каждого i вычисляем:
///    rightSum = total - leftSum - nums[i].
///    Если leftSum == rightSum → нашли pivot.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
///
/// Пример 1:
/// Input:  nums = [1,7,3,6,5,6]
/// Процесс:
/// i=0: left=0, right=27 → не равно  
/// i=1: left=1, right=20 → не равно  
/// i=2: left=8, right=17 → не равно  
/// i=3: left=11, right=11 ✅ → pivot=3
/// Output: 3
/// </summary>
public class Lc0724FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        // 1️⃣ Считаем общую сумму
        var total = nums.Sum();

        // 2️⃣ Накопитель суммы слева
        var leftSum = 0;

        // 3️⃣ Проходим по всем индексам
        for (var i = 0; i < nums.Length; i++)
        {
            // Правая сумма = total - левая сумма - текущий элемент
            var rightSum = total - leftSum - nums[i];

            // Проверяем равенство
            if (leftSum == rightSum)
                return i; // нашли индекс

            // Добавляем текущий элемент к левой сумме
            leftSum += nums[i];
        }

        // 4️⃣ Если ничего не нашли — возвращаем -1
        return -1;
    }
}