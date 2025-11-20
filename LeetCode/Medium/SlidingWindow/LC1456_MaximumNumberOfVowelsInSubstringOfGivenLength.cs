namespace LeetCode.Medium.SlidingWindow;

/// <summary>
/// 1456. Maximum Number of Vowels in a Substring of Given Length
/// Условие: найти максимум гласных в любой подстроке длины k.
///
/// Подход (скользящее окно):
/// 1. Подсчитываем количество гласных в первом окне длины k.
/// 2. Для каждого следующего окна:
///    - Убираем уходящий символ (если гласный, уменьшаем счётчик).
///    - Добавляем новый символ (если гласный, увеличиваем счётчик).
/// 3. Обновляем максимум на каждом шаге.
///
/// Сложность:
/// - Время: O(n) — один проход по строке
/// - Память: O(1) — только счётчики
///
/// Пример:
/// Input: s = "abciiidef", k = 3
/// Output: 3
/// Объяснение:
/// - Окно "abc": 1 гласная (a)
/// - Окно "bci": 1 гласная (i)
/// - Окно "cii": 2 гласные (i, i)
/// - Окно "iii": 3 гласные (i, i, i) ✅ максимум
/// - Окно "iid": 2 гласные (i, i)
/// - Окно "ide": 2 гласные (i, e)
/// - Окно "def": 1 гласная (e)
/// </summary>
public class Lc1456MaximumNumberOfVowelsInSubstringOfGivenLength
{
    public int MaxVowels(string s, int k)
    {
        bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        int current = 0, best = 0;
        for (var i = 0; i < k; i++) if (IsVowel(s[i])) current++;
        best = current;
        for (var i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k])) current--;
            if (IsVowel(s[i])) current++;
            if (current > best) best = current;
        }
        return best;
    }
}


