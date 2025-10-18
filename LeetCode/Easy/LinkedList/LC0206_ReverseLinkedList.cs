namespace LeetCode.Easy.LinkedList;

/// <summary>
/// 206. Reverse Linked List
/// Условие: развернуть односвязный список.
///
/// Подход (итеративно): перекидываем next на предыдущий узел, двигаемся вперёд.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0206ReverseLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null) { this.val = val; this.next = next; }
    }

    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? curr = head;
        while (curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}


