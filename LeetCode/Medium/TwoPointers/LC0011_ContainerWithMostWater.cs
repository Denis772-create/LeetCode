namespace LeetCode.Medium.TwoPointers;

/// <summary>
/// 11. Container With Most Water
/// Условие: даны высоты вертикальных линий (массив height).  
/// Нужно выбрать две линии, которые вместе с осью X образуют контейнер,  
/// в котором помещается наибольшее количество воды.
///
/// Подход (два указателя):
/// 1. Ставим два указателя: left = 0 и right = n - 1.
/// 2. На каждом шаге вычисляем площадь:
///    area = min(height[left], height[right]) * (right - left)
/// 3. Обновляем максимум.
/// 4. Двигаем тот указатель, где высота меньше (так можно попробовать увеличить min).
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
///
/// Пример:
/// Input:  height = [1,8,6,2,5,4,8,3,7]
/// Ход работы:
/// - left=0, right=8 → min(1,7)*(8)=8
/// - left=1, right=8 → min(8,7)*(7)=49 ✅
/// - left=1, right=7 → min(8,3)*(6)=18
/// - left=1, right=6 → min(8,8)*(5)=40
/// - ...
/// Максимум = 49
///
/// Output: 49
/// </summary>
public class Lc0011ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var best = 0;

        // Пока указатели не пересеклись
        while (left < right)
        {
            // Площадь = высота меньшей линии * расстояние между линиями
            var area = Math.Min(height[left], height[right]) * (right - left);

            // Обновляем максимум, если нашли больше
            if (area > best)
                best = area;

            // Двигаем указатель с меньшей высотой к центру
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return best;
    }
}