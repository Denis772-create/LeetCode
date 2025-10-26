namespace LeetCode.Medium.Heap_PriorityQueue;

/// <summary>
/// 215. Kth Largest Element in an Array
///
/// Идея:
/// Нужно найти k-й по величине элемент массива.
///
/// Подход (min-heap):
/// 1️⃣ Используем приоритетную очередь (минимальную кучу) размером k.
/// 2️⃣ Добавляем элементы по одному:
///     - Если в куче < k элементов → добавляем.
///     - Если num > минимального (pq.Peek()) → удаляем минимум и вставляем новый.
/// 3️⃣ После прохода по массиву в корне кучи (Peek) — k-й по величине элемент.
///
/// Сложность:
/// - Время: O(n log k)
/// - Память: O(k)
///
/// Пример:
/// nums = [3,2,3,1,2,4,5,5,6], k = 4
/// ➜ отсортированный порядок: [1,2,2,3,3,4,5,5,6]
/// 🎯 4-й с конца → 4
/// </summary>
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // PriorityQueue<int, int> — min-heap по второму параметру (priority)
        var pq = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            if (pq.Count < k)
            {
                pq.Enqueue(num, num); // добавляем элемент с приоритетом = его значению
            }
            else if (num > pq.Peek())
            {
                pq.Dequeue();         // удаляем минимальный (наименьший из k)
                pq.Enqueue(num, num); // добавляем новый больший
            }
        }

        // Минимальный элемент в куче — это k-й по величине
        return pq.Peek();
    }
}