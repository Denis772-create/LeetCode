namespace LeetCode.Easy.LinkedList;

/// <summary>
/// 21. Merge Two Sorted Lists
/// Условие: объединить два отсортированных односвязных списка в один отсортированный список.
///
/// Подход (слияние с фиктивной головой):
/// 1. Создаём фиктивный узел (dummy) для упрощения логики.
/// 2. Используем указатель current для построения результата.
/// 3. Пока оба списка не пусты:
///    - Сравниваем значения головных узлов.
///    - Присоединяем меньший узел к current.
///    - Перемещаем указатель выбранного списка вперёд.
/// 4. Присоединяем остаток непустого списка.
///
/// Сложность:
/// - Время: O(n + m), где n и m — длины списков
/// - Память: O(1) — только фиктивный узел
///
/// Пример:
/// Input: list1 = [1,2,4], list2 = [1,3,4]
/// Output: [1,1,2,3,4,4]
/// Объяснение: сливаем два отсортированных списка в один
/// </summary>
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