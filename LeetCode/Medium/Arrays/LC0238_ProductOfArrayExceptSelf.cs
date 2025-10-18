namespace LeetCode.Medium.Arrays;

/// <summary>
/// 238. Product of Array Except Self
/// Условие: для каждого индекса выдать произведение всех элементов массива, кроме nums[i]. Без деления.
///
/// Подход: один проход слева (префиксы), один справа (суффиксы), перемножаем в ответе.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1) вне результата
/// </summary>
public class Lc0238ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        var ans = new int[n];
        int left = 1;
        for (int i = 0; i < n; i++) { ans[i] = left; left *= nums[i]; }
        int right = 1;
        for (int i = n - 1; i >= 0; i--) { ans[i] *= right; right *= nums[i]; }
        return ans;
    }
}


