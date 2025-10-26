namespace LeetCode.Easy.Strings;

/// <summary>
/// 1071. Greatest Common Divisor of Strings
/// Условие: для строк str1 и str2 найти наибольшую строку x, такую что
/// str1 = x + x + ... и str2 = x + x + ... (конкатенации).
///
/// Идея:
/// 1. Если str1 + str2 != str2 + str1, значит нет общей повторяющейся структуры — возвращаем "".
/// 2. Иначе ответ — это префикс длиной gcd(len(str1), len(str2)).
///
/// Сложность:
/// - Время: O(n), где n = len(str1) + len(str2)
/// - Память: O(1) вне результата
///
/// Пример:
/// Input: str1 = "ABCABC", str2 = "ABC"
/// Output: "ABC"
/// Объяснение:
/// - Оба состоят из повторений "ABC"
///
/// Ещё пример:
/// Input: str1 = "ABABAB", str2 = "ABAB"
/// Output: "AB"
///
/// Ещё пример:
/// Input: str1 = "LEET", str2 = "CODE"
/// Output: ""
/// Объяснение:
/// - str1 + str2 != str2 + str1, значит общего делителя нет.
/// </summary>
public class Lc1071GcdOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) 
            return string.Empty;
        
        // Находим наибольший общий делитель длин строк
        // Например, len("ABCABC") = 6, len("ABC") = 3 → gcd(6,3) = 3
        int k = Gcd(str1.Length, str2.Length);
        
        // Возвращаем префикс длиной k — это и есть повторяющаяся основа
        // В примере выше: str1.Substring(0, 3) = "ABC"
        return str1.Substring(0, k);
    }

    // Вспомогательная функция для нахождения НОД (алгоритм Евклида)
    private static int Gcd(int a, int b)
    {
        // Пример: a = 6, b = 3
        //
        // Шаг 1: t = a % b = 6 % 3 = 0
        //         a = b = 3
        //         b = t = 0
        // Выход из цикла → возвращаем a = 3
        //
        // → НОД(6, 3) = 3
        //
        // Другой пример: a = 10, b = 4
        //
        // Шаг 1: t = 10 % 4 = 2 → (a, b) = (4, 2)
        // Шаг 2: t = 4 % 2 = 0  → (a, b) = (2, 0)
        // Возвращаем a = 2 → НОД(10, 4) = 2
        
        // Пока b не 0, повторяем деление с остатком
        while (b != 0)
        {
            var t = a % b;  // Остаток
            a = b;             // Сдвигаем значения
            b = t;
        }
        return a; // Когда b == 0, a — это НОД
    }
}