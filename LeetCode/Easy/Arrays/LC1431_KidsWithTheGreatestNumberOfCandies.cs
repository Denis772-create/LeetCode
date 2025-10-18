namespace LeetCode.Easy.Arrays;

/// <summary>
/// 1431. Kids With the Greatest Number of Candies
/// Условие: для каждого ребёнка определить, может ли он иметь наибольшее кол-во конфет,
/// если ему добавить extraCandies.
///
/// Подход: находим максимум в candies, затем сравниваем candies[i] + extraCandies с максимумом.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n) для результирующего массива булей
/// </summary>
public class Lc1431KidsWithTheGreatestNumberOfCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = candies.Max();
        var result = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
            result[i] = candies[i] + extraCandies >= max;
        return result;
    }
}


