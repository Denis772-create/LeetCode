namespace LeetCode.Medium.LinkedList;

/// <summary>
/// 2095. Delete the Middle Node of a Linked List
/// Условие: удалить средний узел из односвязного списка и вернуть голову.
/// Средний узел — это ⌊n / 2⌋-й элемент (0-based).
///
/// Подход (два указателя):
/// - Если список из одного элемента → возвращаем null.
/// - Идём двумя указателями:
///   slow — по одному шагу, fast — по два.
/// - Когда fast достигнет конца, slow будет в середине.
/// - prev указывает на элемент перед slow, поэтому prev.next = slow.next.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
///
/// Пример 1:
/// Input:  [1,3,4,7,1,2,6]
/// Вычисления:
/// n=7 → middle=⌊7/2⌋=3 (значение 7)
/// Output: [1,3,4,1,2,6]
///
/// Пример 2:
/// Input:  [1,2,3,4]
/// n=4 → middle=⌊4/2⌋=2 (значение 3)
/// Output: [1,2,4]
///
/// Пример 3:
/// Input:  [2,1]
/// n=2 → middle=⌊2/2⌋=1 (значение 1)
/// Output: [2]
/// </summary>
public class Lc2095DeleteTheMiddleNodeOfALinkedList
{
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

    public ListNode? DeleteMiddle(ListNode? head)
    {
        // 1️⃣ Если один элемент — просто удаляем
        if (head?.next == null)
            return null;

        ListNode? slow = head;  // идёт по одному шагу
        ListNode? fast = head;  // идёт по два шага
        ListNode? prev = null;  // элемент перед slow

        // 2️⃣ Ищем середину
        while (fast is { next: not null })
        {
            prev = slow;
            slow = slow!.next;
            fast = fast.next.next;
        }

        // 3️⃣ Удаляем средний элемент
        prev!.next = slow!.next;

        return head;
    }
}