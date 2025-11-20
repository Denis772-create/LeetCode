namespace LeetCode.Medium.LinkedList;

/// <summary>
/// 2130. Maximum Twin Sum of a Linked List
/// Условие: найти максимальную сумму "близнецов" в списке длины n (чётной).
/// Близнецы — это пары (i-й элемент, (n-1-i)-й элемент).
///
/// Подход:
/// 1. Собираем все значения в массив.
/// 2. Для каждой пары (i, n-1-i) вычисляем сумму.
/// 3. Возвращаем максимум.
///
/// Сложность:
/// - Время: O(n) — один проход для сбора значений, один для поиска максимума
/// - Память: O(n) — для массива значений
///
/// Пример:
/// Input: head = [5,4,2,1]
/// Пары: (5,1) → сумма 6, (4,2) → сумма 6
/// Output: 6
///
/// Пример 2:
/// Input: head = [4,2,2,3]
/// Пары: (4,3) → сумма 7, (2,2) → сумма 4
/// Output: 7
/// </summary>
public class Solution2130
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }

    public int PairSum(ListNode head)
    {
        var vals = new List<int>(1024);
        for (var cur = head; cur != null; cur = cur.next)
        {
            vals.Add(cur.val);
        }

        var n = vals.Count;
        var ans = 0;
        for (var i = 0; i < n / 2; i++)
        {
            ans = Math.Max(ans, vals[i] + vals[n - 1 - i]);
        }

        return ans;
    }
}