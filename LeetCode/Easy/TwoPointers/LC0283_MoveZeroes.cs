namespace LeetCode.Easy.TwoPointers;

/// <summary>
/// 283. Move Zeroes
/// Условие: переместить все нули в конец массива, сохранив порядок ненулевых.
///
/// Подход (два указателя): pointer — позиция следующего ненулевого элемента.
/// Идём по массиву, если nums[i] != 0, переносим его на nums[pointer], а текущий i ставим в 0
/// только если i != pointer. Увеличиваем pointer.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0283MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        int pointer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != pointer)
                {
                    nums[pointer] = nums[i];
                    nums[i] = 0;
                }
                pointer++;
            }
        }
    }
}


