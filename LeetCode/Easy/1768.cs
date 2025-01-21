using System.Text;

namespace LeetCode.Easy;

/*
 * 1768. Merge Strings Alternately
 * You are given two strings word1 and word2.
 * Merge the strings by adding letters in alternating order, starting with word1.
 * If a string is longer than the other, append the additional letters onto the end of the merged string.
 */

internal class Solution1768
{
    public string MergeAlternately(string word1, string word2)
    {
        var maxSize = word1.Length > word2.Length ? word1.Length : word2.Length;
        var result = new StringBuilder();

        for (var i = 0; i < maxSize; i++)
        {
            if (word1.Length > i)
            {
                result.Append(word1[i]);
            }

            if (word2.Length > i)
            {
                result.Append(word2[i]);
            }
        }
        return result.ToString();
    }
}