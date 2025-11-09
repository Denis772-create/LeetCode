namespace LeetCode.Medium.LinkedList;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        // Если список пустой или в нём 1 элемент — ничего менять не нужно
        if (head?.next == null)
            return head;
        
        // odd — указатель на текущий нечётный узел
        // even — указатель на текущий чётный узел
        // evenHead — запомним начало списка с чётными узлами, чтобы потом присоединить его
        var odd = head;
        var even = head.next;
        var evenHead = even;
        
        // Пока есть следующий чётный и нечётный узлы
        while (even is { next: not null })
        {
            // Пропускаем один узел для нечётного
            odd.next = even.next;
            odd = odd.next;
            
            // Пропускаем один узел для чётного
            even.next = odd.next;
            even = even.next;
        }
        
        // В конце соединяем два списка
        odd.next = evenHead;
        
        return head;
    }
}