namespace LeetCode.Easy
{
    public class Solution605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            int length = flowerbed.Length;

            for (int i = 0; i < length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool emptyLeft = i == 0 || flowerbed[i - 1] == 0;
                    bool emptyRight = i == length - 1 || flowerbed[i + 1] == 0;

                    if (emptyLeft && emptyRight)
                    {
                        flowerbed[i] = 1; // Plant a flower here
                        count++;
                    }
                }
            }

            return count >= n;
        }
    }
}
