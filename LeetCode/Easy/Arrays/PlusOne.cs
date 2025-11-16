namespace LeetCode.Easy.Arrays;

public class PlusOne12
{
    public int[] PlusOne(int[] digits)
    {
        // идём с конца массива
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            // если цифра меньше 9 — просто +1 и готово
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            
            // если цифра была 9 — превращаем её в 0 и переносим 1 дальше
            digits[i] = 0;
        }
        
        // если мы здесь — значит ВСЕ цифры были 9
        // создаём новый массив: [1, 0, 0, ...]
        int[] result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}