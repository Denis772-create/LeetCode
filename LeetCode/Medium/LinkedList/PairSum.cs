namespace LeetCode.Medium.LinkedList;

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