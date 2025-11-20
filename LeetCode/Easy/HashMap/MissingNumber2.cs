namespace LeetCode.Easy.HashMap;

/// <summary>
/// 268. Missing Number
/// Условие: дан массив nums, содержащий n различных чисел в диапазоне [0, n]. Вернуть единственное число из диапазона [0, n], которого нет в массиве.
///
/// Подход (HashSet):
/// 1. Добавляем все числа из массива в HashSet.
/// 2. Проходим по числам от 0 до n включительно.
/// 3. Если число отсутствует в HashSet → это пропущенное число.
///
/// Сложность:
/// - Время: O(n) — два прохода
/// - Память: O(n) — для HashSet
///
/// Пример 1:
/// Input: nums = [3,0,1]
/// Output: 2
/// Объяснение: n = 3, числа должны быть [0,1,2,3]. Отсутствует 2.
///
/// Пример 2:
/// Input: nums = [0,1]
/// Output: 2
/// Объяснение: n = 2, числа должны быть [0,1,2]. Отсутствует 2.
/// </summary>
public class MissingNumber2
{
    public int MissingNumber(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int n = nums.Length;

        for (int i = 0; i <= n; i++)
        {
            if (!set.Contains(i)) {
                return i;  // нашли пропавшее число
            }
        }
        
        return -1; // сюда не дойдём по условию задачи
    }
}