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
///
/// Пример:
/// Input:
///     candies = [2,3,5,1,3],
///     extraCandies = 3
/// Output: [true,true,true,false,true]
/// Объяснение:
/// - 2 + 3 = 5 → true
/// - 3 + 3 = 6 → true
/// - 5 + 3 = 8 → true
/// - 1 + 3 = 4 → false
/// - 3 + 3 = 6 → true
/// </summary>
public class Lc1431KidsWithTheGreatestNumberOfCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        var result = new bool[candies.Length];
        for (var i = 0; i < candies.Length; i++)
        {
            result[i] = candies[i] + extraCandies >= max;
        }
        return result;
    }
}


