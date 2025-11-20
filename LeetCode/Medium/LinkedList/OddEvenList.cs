namespace LeetCode.Medium.LinkedList;

/// <summary>
/// 328. Odd Even Linked List
/// Условие: перегруппировать список так, чтобы все узлы с нечётными индексами шли первыми,
/// затем все узлы с чётными индексами. Индексация начинается с 0.
///
/// Подход:
/// 1. Разделяем список на два: нечётные и чётные узлы.
/// 2. Поддерживаем указатели на текущие нечётный и чётный узлы.
/// 3. На каждом шаге: odd.next = even.next, even.next = odd.next.next.
/// 4. В конце соединяем нечётный список с чётным.
///
/// Сложность:
/// - Время: O(n) — один проход по списку
/// - Память: O(1) — только указатели
///
/// Пример:
/// Input: head = [1,2,3,4,5]
/// Output: [1,3,5,2,4]
/// Объяснение:
/// - Нечётные индексы (0,2,4): 1, 3, 5
/// - Чётные индексы (1,3): 2, 4
/// </summary>
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