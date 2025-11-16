namespace LeetCode.Easy.TwoPointers;

/// <summary>
/// 283. Move Zeroes
/// Условие: переместить все нули в конец массива, сохранив порядок ненулевых элементов.
///
/// Подход (два указателя):
/// - pointer указывает, куда ставить следующий ненулевой элемент.
/// - Проходим массив:
///     если nums[i] != 0 → переносим его в nums[pointer].
///     Если i != pointer, обнуляем старую позицию.
///     pointer++.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
///
/// Пример:
/// Input:  [0,1,0,3,12]
///
/// Output: [1,3,12,0,0]
/// </summary>
public class Lc0283MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        int insertPos = 0;
        
        // Сначала переносим все НЕ нули в начало массива
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }
        
        // Остальное заполняем нулями
        while (insertPos < nums.Length)
        {
            nums[insertPos] = 0;
            insertPos++;
        }
    }
}