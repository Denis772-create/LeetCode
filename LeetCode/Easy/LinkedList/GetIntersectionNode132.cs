namespace LeetCode.Easy.LinkedList;

public class GetIntersectionNode132
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var set = new HashSet<ListNode>();
        
        ListNode cur = headA;
        while (cur != null)
        {
            set.Add(cur);
            cur = cur.next;
        }
        
        cur = headB;
        while (cur != null)
        {
            if (set.Contains(cur))
            {
                return cur;
            }
        }
        return null;
    }
}