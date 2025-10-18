namespace LeetCode.Easy.Strings;

/// <summary>
/// 1071. Greatest Common Divisor of Strings
/// Условие: для строк str1 и str2 найти наибольшую строку x, такую что
/// str1 = x + x + ... и str2 = x + x + ... (конкатенации).
///
/// Идея: если str1 + str2 != str2 + str1, общего делителя не существует.
/// Тогда ответ пустая строка. Иначе ответ — префикс длиной gcd(len1, len2).
///
/// Сложность:
/// - Время: O(n), где n = len(str1) + len(str2)
/// - Память: O(1) вне результата
/// </summary>
public class Lc1071GcdOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        if ((str1 + str2) != (str2 + str1)) return string.Empty;
        int k = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, k);
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int t = a % b;
            a = b;
            b = t;
        }
        return a;
    }
}


