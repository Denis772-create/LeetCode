namespace LeetCode.Easy.Strings;

public class StrStr3
{
    public int StrStr(string haystack, string needle)
    {
        // Если needle пустая строка — по правилам вернуть 0
        if (needle.Length == 0)
            return 0;

        // Если needle длиннее, чем haystack — она точно не поместится
        if (needle.Length > haystack.Length)
            return -1;
        
        // Проходим по haystack
        // i — это позиция, откуда мы пробуем начать сравнение
        for (int i = 0; i < haystack.Length - needle.Length; i++)
        {
            // Считаем, что совпадение есть, пока не доказано обратное
            bool match = true;
            
            // Проверяем каждый символ needle
            for (int j = 0; j < needle.Length; j++)
            {
                // Если хоть один символ не совпадает — это НЕ то место
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                return i;
            }
        }
        
        // Если дошли до конца и не нашли needle — возвращаем -1
        return -1;
    }
}