namespace LeetCode.Easy.HashMap;

public class MissingNumber2
{
    public int MissingNumber(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int n = nums.Length;

        for (int i = 0; i <= n; i++)
        {
            if (!set.Contains(i)) {
                return i;  // нашли пропавшее число
            }
        }
        
        return -1; // сюда не дойдём по условию задачи
    }
}