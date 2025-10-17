using LeetCode.Easy.LinkedList;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 🧩 Prepare the test data: [1,2,3,4,5]
            ListNode head = new ListNode(1,
                new ListNode(2,
                    new ListNode(3,
                        new ListNode(4,
                            new ListNode(5)))));

            // ✅ Call ReverseList with your prepared list
            new Solution().ReverseList(head, true);        }
    }
}
