namespace LeetCode.Medium.Strings;

public class LongestPalindrome2
{
    public string LongestPalindrome(string s)
    {
        // Если строка пустая или из одного символа — она и есть ответ
        if (s == null || s.Length < 2)
            return s;
        
        // Индекс начала лучшего палиндрома
        int bestStart = 0;
        // Длина лучшего палиндрома (минимум 1 символ)
        int bestLen = 1;
        
        // Проходим по каждому символу строки — он будет "центром" палиндрома
        for (int i = 0; i < s.Length; i++)
        {
            // 1) Считаем, что центр палиндрома — один символ (нечётная длина)
            //    Пример: "aba" — центр 'b'
            ExpandAroundCenter(s, i, i, ref bestStart, ref bestLen);

            // 2) Считаем, что центр палиндрома — между двумя символами (чётная длина)
            //    Пример: "abba" — центр между 'b' и 'b'
            ExpandAroundCenter(s, i, i + 1, ref bestStart, ref bestLen);
        }
        
        // Вырезаем из строки найденный самый длинный палиндром
        return s.Substring(bestStart, bestLen);
    }
    
    // Вспомогательный метод:
    // "Раздуваем" палиндром от центра (left, right)
    // и, если нашли более длинный, обновляем bestStart и bestLen
    private void ExpandAroundCenter(string s, int left, int right,
        ref int bestStart, ref int bestLen)
    {
        // Пока не вышли за границы строки
        // и символы слева и справа совпадают — расширяемся
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        
        // В этот момент цикл остановился, и текущие left и right
        // уже УШЛИ ЗА пределы палиндрома.
        // Настоящие границы палиндрома:
        //   start = left + 1
        //   end   = right - 1
        int currentStart = left + 1;
        int currentLen = right - left - 1; // (right - 1) - (left + 1) + 1
        
        // Если найденный палиндром длиннее лучшего — обновляем ответ
        if (currentLen > bestLen)
        {
            bestStart = currentStart;
            bestLen = currentLen;
        }
    }
}