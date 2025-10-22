namespace LeetCode.Medium.MonotonicStack;

// Input: temperatures = [73,74,75,71,69,72,76,73]
// Output: [1,1,4,2,1,1,0,0]
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var n = temperatures.Length;
        var ans = new int[n];
        var st = new Stack<int>(); // храним индексы
        
        for (var i = 0; i < n; i++)
        {
            while (st.Count > 0 && temperatures[i] > temperatures[st.Peek()])
            {
                int prev  = st.Pop();
                ans[prev] = i - prev; // сколько дней ждать потепления
            }

            st.Push(i); // добавляем текущий индекс
        }
        
        // для оставшихся в стеке дней ответа нет (0 уже по умолчанию)
        return ans;
    }
}