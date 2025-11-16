namespace LeetCode.Easy.LinkedList;

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

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Создаем фиктивную голову для упрощения
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        // Пока оба списка не пусты
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        // Если один из списков закончился, присоединяем остаток другого
        current.next = list1 ?? list2;

        return dummy.next;
    }
}