aanamespace LeetCode.Easy.LinkedList;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

//[1,2,3]
public class Solution
{
    private ListNode resultHead;
    public ListNode ReverseList(ListNode head, bool isHead = true)
    {
        if (head?.next == null && isHead)
            return head;
        
        // первый
        var current = head;
        
        // следующий
        var next = head?.next;
        
        // первый теперь последний
        if (isHead)
        {
            current.next = null; // 1
            resultHead = current;
            isHead = false;
        }
        else
        {
            if (next is null)
            {
                resultHead = next;
                return resultHead;
            }
            next.next = resultHead;
            resultHead = head.next;
        }
        
        return ReverseList(next, isHead);
    }
}

// 1. получаем первый нод, если у него next пустой то сразу возвращаем его при условии что это голова
// 2. делаем его последним = next = null
// 3. получаем второй эллемент и даем ему ссылку на первый и так далее 
// 4. когда дойдем до последней возвращаем ответ