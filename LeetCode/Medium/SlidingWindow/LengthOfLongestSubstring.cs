namespace LeetCode.Medium.SlidingWindow;

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