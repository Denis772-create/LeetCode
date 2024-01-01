namespace LeetCode;

internal class Solution1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandiesAmongAll = candies.Max();
        var candieswithExtrAmount = new bool[candies.Length];

        for (var i = 0; i < candies.Length; i++)
        {
            candieswithExtrAmount[i] = candies[i] + extraCandies >= maxCandiesAmongAll;
        }

        return candieswithExtrAmount;
    }
}
