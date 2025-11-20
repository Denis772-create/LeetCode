namespace LeetCode.Easy.HashMap;

/// <summary>
/// 217. Contains Duplicate
/// Условие: проверить, содержит ли массив дубликаты. Вернуть true, если хотя бы одно значение встречается дважды.
///
/// Подход (HashSet):
/// 1. Проходим по массиву и добавляем элементы в HashSet.
/// 2. Если элемент уже есть в HashSet → найден дубликат, возвращаем true.
/// 3. Если прошли весь массив без дубликатов → возвращаем false.
///
/// Сложность:
/// - Время: O(n) — один проход по массиву
/// - Память: O(n) — для HashSet в худшем случае
///
/// Пример 1:
/// Input: nums = [1,2,3,1]
/// Output: true
/// Объяснение: число 1 встречается дважды
///
/// Пример 2:
/// Input: nums = [1,2,3,4]
/// Output: false
/// Объяснение: все числа уникальны
/// </summary>
public class ContainsDuplicate2
{
    public bool ContainsDuplicate(int[] nums)
    {
        var seen = new HashSet<int>();

        foreach (int n in nums)
        {
            if (seen.Contains(n))
            {
                return true;  // нашли дубликат
            }
            seen.Add(n);
        }
        return false;
    }
}