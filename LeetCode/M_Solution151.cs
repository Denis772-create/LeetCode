namespace LeetCode;

internal class M_Solution151
{
    public string ReverseWords(string s)
    {
        var wordsArray = s.Split(' ');
        var reversedWordsArray = wordsArray.Reverse();
        return string.Join(" ", reversedWordsArray.Where(x => x != ""));
    }
}