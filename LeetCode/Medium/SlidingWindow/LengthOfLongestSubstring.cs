namespace LeetCode.Medium.SlidingWindow;

/// <summary>
/// 3. Longest Substring Without Repeating Characters
/// Условие: найти длину самой длинной подстроки без повторяющихся символов.
///
/// Подход (скользящее окно с HashSet):
/// 1. Используем два указателя: left и right.
/// 2. Используем HashSet для отслеживания символов в текущем окне.
/// 3. Расширяем окно вправо (right++), добавляя символы в HashSet.
/// 4. Если символ уже есть в HashSet → сдвигаем left, удаляя символы, пока дубликат не исчезнет.
/// 5. На каждом шаге обновляем максимальную длину.
///
/// Сложность:
/// - Время: O(n) — каждый символ посещается максимум дважды
/// - Память: O(min(n, m)), где m — размер алфавита
///
/// Пример 1:
/// Input: s = "abcabcbb"
/// Output: 3
/// Объяснение: самая длинная подстрока без повторов — "abc" (длина 3)
///
/// Пример 2:
/// Input: s = "bbbbb"
/// Output: 1
/// Объяснение: самая длинная подстрока — "b" (длина 1)
///
/// Пример 3:
/// Input: s = "pwwkew"
/// Output: 3
/// Объяснение: самая длинная подстрока — "wke" (длина 3)
/// </summary>
public class LengthOfLongestSubstring3
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> window = new HashSet<char>(); // текущее окно без повторов
        
        
        int left = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            
            // если символ уже в окне — сдвигаем left, пока он не исчезнет
            while (window.Contains(c))
            {
                window.Remove(s[left]);
                left++;
            }
            
            // теперь символ уникален — добавляем его в окно
            window.Add(c);
            
            // обновляем максимальную длину
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        
        return maxLen;
    }
}