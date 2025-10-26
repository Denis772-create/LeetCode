namespace LeetCode.Easy.Strings;

/// <summary>
/// 345. Reverse Vowels of a String
/// Условие: развернуть порядок только гласных в строке, остальные символы оставить на местах.
///
/// Подход (два указателя):
/// 1. Устанавливаем два указателя — left и right.
/// 2. Двигаем их к центру, пока оба не укажут на гласные.
/// 3. Меняем эти гласные местами и продолжаем.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1) (in-place на массиве символов)
///
/// Пример:
/// Input: s = "hello"
/// Output: "holle"
/// Объяснение:
/// - Гласные: 'e' и 'o'
/// - После разворота их порядок меняется: "holle"
///
/// Ещё пример:
/// Input: s = "leetcode"
/// Output: "leotcede"
/// </summary>
public class Lc0345ReverseVowelsOfAString
{
    public string ReverseVowels(string s)
    {
        if (string.IsNullOrEmpty(s)) 
            return s;
        
        var chars = s.ToCharArray();
        int left = 0, right = chars.Length - 1;

        while (left < right)
        {
            while (left < right && !IsVowel(chars[left])) left++;
            while (left < right && !IsVowel(chars[right])) right--;
            
            if (left < right)
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);
                left++;
                right--;
            }
        }

        return new string(chars);

        bool IsVowel(char c)
        {
            return c is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U';
        }
    }
}