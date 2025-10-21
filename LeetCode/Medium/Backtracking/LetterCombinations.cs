namespace LeetCode.Medium.Backtracking;

public class Solution
{
    private static readonly Dictionary<char, string> map = new()
    {
        ['2'] = "abc",
        ['3'] = "def",
        ['4'] = "ghi",
        ['5'] = "jkl",
        ['6'] = "mno",
        ['7'] = "pqrs",
        ['8'] = "tuv",
        ['9'] = "wxyz"
    };
    
    public IList<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if (string.IsNullOrEmpty(digits)) return res;
        
        var path = new char[digits.Length];

        void Dfs(int i)
        {
            if (i == digits.Length)
            {
                res.Add(new string(path));
                return; 
            }

            if (!map.TryGetValue(digits[i], out var letters))
                return; // на случай чужих символов

            foreach (var ch in letters)
            {
                path[i] = ch;
                Dfs(i + 1);
            }
        }
        
        Dfs(0);
        return res;
    }
}