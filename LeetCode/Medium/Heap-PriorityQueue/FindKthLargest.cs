namespace LeetCode.Medium.Heap_PriorityQueue;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>(k);

        foreach (var num in nums)
        {
            if (pq.Count < k)
            {
                pq.Enqueue(num, num);
            }
            else if (num > pq.Peek())
            {
                pq.Dequeue();
                pq.Enqueue(num, num);
            }
        }

        return pq.Peek();
    }
}
