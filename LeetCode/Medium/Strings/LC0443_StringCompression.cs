namespace LeetCode.Medium.Strings;

/// <summary>
/// 443. String Compression
/// Условие: сжать массив символов на месте: 'a','a','a' -> 'a','3'. Вернуть новую длину.
///
/// Подход: два указателя — счётчик группы, записываем символ и его count как цифры.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0443StringCompression
{
    public int Compress(char[] chars)
    {
        int write = 0, i = 0;
        while (i < chars.Length)
        {
            char c = chars[i];
            int count = 0;
            while (i < chars.Length && chars[i] == c) { i++; count++; }
            chars[write++] = c;
            if (count > 1)
            {
                foreach (char d in count.ToString())
                    chars[write++] = d;
            }
        }
        return write;
    }
}


