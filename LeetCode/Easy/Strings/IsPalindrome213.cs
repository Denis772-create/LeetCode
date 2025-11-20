namespace LeetCode.Easy.Strings;

/// <summary>
/// 125. Valid Palindrome
/// Условие: проверить, является ли строка палиндромом. Учитывать только буквенно-цифровые символы, игнорировать регистр.
///
/// Подход (два указателя):
/// 1. Используем два указателя: left (начало) и right (конец).
/// 2. Пропускаем не буквенно-цифровые символы.
/// 3. Сравниваем символы в нижнем регистре.
/// 4. Если не совпадают → не палиндром.
/// 5. Продолжаем, пока left < right.
///
/// Сложность:
/// - Время: O(n) — один проход по строке
/// - Память: O(1)
///
/// Пример 1:
/// Input: s = "A man, a plan, a canal: Panama"
/// Output: true
/// Объяснение: "amanaplanacanalpanama" — палиндром
///
/// Пример 2:
/// Input: s = "race a car"
/// Output: false
/// Объяснение: "raceacar" не является палиндромом
/// </summary>
public class IsPalindrome213
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
}