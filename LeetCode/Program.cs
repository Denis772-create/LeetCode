using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _136 solution = new _136();

            Console.WriteLine(solution.SingleNumber([2, 2, 1])); // Output: 1
            Console.WriteLine(solution.SingleNumber([4, 1, 2, 1, 2])); // Output: 4
            Console.WriteLine(solution.SingleNumber([1])); // Output: 1        }
        }
    }
}
