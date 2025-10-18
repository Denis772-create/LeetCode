namespace LeetCode.Medium.Stack;

public class Solution
{
    // O(n) по времени, O(1) доп. память (кроме результата)
    public string RemoveStars(string s)
    {
        var buf = new char[s.Length];
        var top = 0;

        foreach (char c in s)
        {
            if (c != '*')
            {
                buf[top++] = c;   // «положили» символ
            }
            else
            {
                top--;             // «съели» ближайший слева
            }
        }

        return new string(buf, 0, top);
    }
}

/*
 * 1. Создаем стек для хранения букв
 * 2.  добавляем по одной букве до поялвения *
 * 3. как только увидели звезду удаляем из стека букву и движемся дальше
 * 
 */