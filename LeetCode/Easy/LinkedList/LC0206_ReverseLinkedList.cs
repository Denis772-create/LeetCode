namespace LeetCode.Easy.LinkedList;

/// <summary>
/// 206. Reverse Linked List
/// Условие: развернуть односвязный список.
/// Нужно изменить ссылки между узлами, чтобы первый стал последним, а последний — первым.
///
/// Подход (итеративно):
/// 1. Используем три указателя: prev, curr и next.
/// 2. На каждом шаге "переворачиваем" ссылку curr.next на prev.
/// 3. Двигаем prev и curr вперёд.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
///
/// Пример:
/// Input:  1 → 2 → 3 → 4 → 5 → null
/// Шаги:
/// prev=null, curr=1 → 1.next=null  
/// prev=1, curr=2 → 2.next=1 → 2→1  
/// prev=2, curr=3 → 3.next=2 → 3→2→1  
/// ...
/// Output: 5 → 4 → 3 → 2 → 1 → null
/// </summary>
public class Lc0206ReverseLinkedList
{
    public class ListNode
    {
        public int Val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.Val = val;
            this.next = next;
        }
    }

    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;  // предыдущий узел (изначально null)
        ListNode? curr = head;  // текущий узел, с которого начинаем

        while (curr != null)
        {
            // сохраняем следующий узел (чтобы не потерять ссылку)
            var next = curr.next;

            // переворачиваем ссылку: текущий теперь указывает на предыдущий
            curr.next = prev;

            // сдвигаем указатели вперёд
            prev = curr;
            curr = next;
        }

        // prev теперь указывает на новую голову списка
        return prev;
    }
}