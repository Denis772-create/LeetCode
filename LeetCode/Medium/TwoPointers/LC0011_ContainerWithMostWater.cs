namespace LeetCode.Medium.TwoPointers;

/// <summary>
/// 11. Container With Most Water
/// Даны высоты столбиков. Две линии и ось X образуют контейнер. Найти максимальную площадь.
///
/// Подход (два указателя): ставим left в 0, right в n-1. На каждом шаге считаем площадь
/// и двигаем меньшую высоту к центру — это единственный шанс увеличить минимальную высоту.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0011ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, best = 0;
        while (left < right)
        {
            int area = System.Math.Min(height[left], height[right]) * (right - left);
            if (area > best) best = area;
            if (height[left] < height[right]) left++; else right--;
        }
        return best;
    }
}


