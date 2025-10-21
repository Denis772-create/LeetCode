namespace LeetCode.Easy.BinarySearch;

public class GuessGame(int pick)
{
    protected int guess(int num)
    {
        if (num > pick) return -1;
        if (num < pick) return 1;
        return 0;
    }
}

// Класс с решением
public class Solution(int pick) : GuessGame(pick)
{
    public int GuessNumber(int n)
    {
        int left = 1;
        int right = n;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // избегаем переполнения
            int res = guess(mid);

            if (res == 0)
                return mid; // нашли 🎯
            else if (res == 1)
                left = mid + 1; // pick больше → ищем справа
            else
                right = mid - 1; // pick меньше → ищем слева
        }
        
        return -1; // теоретически не должно сюда дойти
    }
}