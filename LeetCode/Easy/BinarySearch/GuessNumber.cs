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
        var arr = Enumerable.Range(1, n).ToArray();

        while (arr.Length > 1)
        {
            int mid = arr.Length / 2;
            int midValue = arr[mid];
            
            int guessResult = guess(midValue);
            if (guessResult == 0)
                return midValue; // угадали 🎯
            
            if (guessResult == 1)
            {
                // pick больше → идём вправо
                arr = arr[(mid + 1)..];
            }
            else
            {
                // pick меньше → идём влево
                arr = arr[..mid];
            }
        }
        
        return arr[0];
    }
}