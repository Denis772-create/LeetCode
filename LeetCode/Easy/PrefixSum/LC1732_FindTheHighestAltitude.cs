namespace LeetCode.Easy.PrefixSum;

/// <summary>
/// 1732. Find the Highest Altitude
/// Условие: имея массив приращений высоты, найти максимальную достигнутую высоту.
///
/// Подход: идём, накапливаем текущую высоту и берём максимум.
/// Стартовая высота 0.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc1732FindTheHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        int altitude = 0;
        int best = 0;
        foreach (var delta in gain)
        {
            altitude += delta;
            if (altitude > best) best = altitude;
        }
        return best;
    }
}


