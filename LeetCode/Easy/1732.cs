namespace LeetCode.Easy;

internal class _1732
{
    public int LargestAltitude(int[] gain)
    {
        int[] altitudes = new int[gain.Length + 1];
        altitudes[0] = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            altitudes[i + 1] = altitudes[i] + gain[i];
        }

        return altitudes.Max();
    }
}
