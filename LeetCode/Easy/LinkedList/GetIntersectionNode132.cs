namespace LeetCode.Easy.LinkedList;

/// <summary>
/// 160. Intersection of Two Linked Lists
/// Условие: найти узел, в котором пересекаются два односвязных списка. Если пересечения нет, вернуть null.
///
/// Подход (HashSet):
/// 1. Проходим по первому списку и добавляем все узлы в HashSet.
/// 2. Проходим по второму списку и проверяем, есть ли текущий узел в HashSet.
/// 3. Если нашли → это узел пересечения.
///
/// Сложность:
/// - Время: O(n + m), где n и m — длины списков
/// - Память: O(n) — для хранения узлов первого списка
///
/// Пример:
/// Input:
///     listA = [4,1,8,4,5], listB = [5,6,1,8,4,5]
///     Пересечение на узле со значением 8
/// Output: ListNode(8)
/// Объяснение: узлы со значением 8 и далее являются общими для обоих списков
/// </summary>
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
            cur = cur.next;
        }
        return null;
    }
}