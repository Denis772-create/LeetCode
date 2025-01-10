namespace LeetCode.Medium;

internal class M_Solution443
{
    public int Compress(char[] chars)
    {
        int index = 0, i = 0;

        while (i < chars.Length)
        {
            char currentChar = chars[i];
            int count = 0;

            while (i < chars.Length && chars[i] == currentChar)
            {
                i++;
                count++;
            }

            chars[index++] = currentChar;
            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[index++] = c;
                }
            }
        }
        return index;
    }
}