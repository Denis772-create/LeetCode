namespace LeetCode.Easy;

internal class Solution345
{
    public string ReverseVowels(string s)
    {
        var allVowelsList = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var vowelsList = new List<char>();
        var charsArray = s.ToCharArray();

        for (var i = 0; i < s.Length; i++)
        {
            if (allVowelsList.Contains(s[i]))
            {
                vowelsList.Add(charsArray[i]);
            }
        }

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (allVowelsList.Contains(s[i]))
            {
                charsArray[i] = vowelsList.First();
                vowelsList.RemoveAt(vowelsList.IndexOf(charsArray[i]));
            }
        }

        return new string(charsArray);
    }
}