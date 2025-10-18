namespace LeetCode.Medium.Stack;

/// <summary>
/// 2390. Removing Stars From a String
/// Условие: удалить символ слева от каждой '*' и саму '*', выполняя слева направо.
///
/// Подход: симулируем стек на массиве char.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1) доп. (кроме результата)
/// </summary>
public class Lc2390RemovingStarsFromAString
{
    public string RemoveStars(string s)
    {
        var buf = new char[s.Length];
        int top = 0;
        foreach (var c in s)
        {
            if (c != '*') 
            {
                buf[top++] = c;
            }
            else
            {
                top--;
            }
        }
        return new string(buf, 0, top);
    }
}


