namespace LeetCode.Easy;

public class _2215
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) 
    {
        // Create lists to store unique elements

        // Remove duplicates from nums1 and nums2
        var list1 = RemoveDuplicates(nums1);
        var list2 = RemoveDuplicates(nums2);

        // Find elements in nums1 that are not in nums2
        var uniqueInNums1 = list1.Where(num => !IsPresent(num, list2)).ToList();

        // Find elements in nums2 that are not in nums1
        var uniqueInNums2 = list2.Where(num => !IsPresent(num, list1)).ToList();

        // Return the result as a list of lists
        return new List<IList<int>> { uniqueInNums1, uniqueInNums2 };
    }

    // Helper method to remove duplicates from an array
    private static List<int> RemoveDuplicates(int[] nums)
    {
        var uniqueList = new List<int>();
        foreach (var num in nums)
        {
            if (!uniqueList.Contains(num))
            {
                uniqueList.Add(num);
            }
        }
        return uniqueList;
    }

    // Helper method to check if a number exists in a list
    private bool IsPresent(int num, List<int> list)
    {
        return list.Any(item => item == num);
    }
}