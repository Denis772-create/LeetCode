namespace LeetCode.Easy.Greedy;

/// <summary>
/// 605. Can Place Flowers
/// Условие: можно ли посадить n цветов в лунки (0/1) не нарушая правило — рядом нельзя.
///
/// Подход (жадный):
/// 1. Идём слева направо по массиву flowerbed.
/// 2. Сажаем цветок в позицию i, если:
///    - flowerbed[i] == 0 (лунка свободна).
///    - Левый сосед пуст (i == 0 или flowerbed[i-1] == 0).
///    - Правый сосед пуст (i == length-1 или flowerbed[i+1] == 0).
/// 3. Подсчитываем посаженные цветы и сравниваем с n.
///
/// Сложность:
/// - Время: O(n) — один проход по массиву
/// - Память: O(1) — только счётчик
///
/// Пример 1:
/// Input: flowerbed = [1,0,0,0,1], n = 1
/// Output: true
/// Объяснение: можно посадить цветок в позицию 2 (индекс 2)
///
/// Пример 2:
/// Input: flowerbed = [1,0,0,0,1], n = 2
/// Output: false
/// Объяснение: нельзя посадить два цветка, не нарушая правило
/// </summary>
public class Lc0605CanPlaceFlowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var planted = 0;
        for (var i = 0; i < flowerbed.Length && planted < n; i++)
        {
            if (flowerbed[i] == 0)
            {
                var leftEmpty = i == 0 || flowerbed[i - 1] == 0;
                var rightEmpty = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
                if (leftEmpty && rightEmpty)
                {
                    flowerbed[i] = 1;
                    planted++;
                }
            }
        }
        return planted >= n;
    }
}


