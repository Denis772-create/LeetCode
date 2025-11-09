namespace LeetCode.Easy.Greedy;

/// <summary>
/// 605. Can Place Flowers
/// Условие: можно ли посадить n цветов в лунки (0/1) не нарушая правило — рядом нельзя.
///
/// Подход (жадный): идём слева направо, сажаем цветок, если ячейка 0 и оба соседа (если есть) равны 0.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
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


