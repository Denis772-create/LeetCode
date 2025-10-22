namespace LeetCode.Medium.Trie;

public class Trie
{
    private class Node
    {
        public Node[] Next = new Node[26]; // дети по буквам a..z
        public bool IsWord;                 // флажок: здесь заканчивается слово
    }
    
    private readonly Node root = new Node();

    public void Insert(string word)
    {
        var cur = root;
        foreach (var ch in word)
        {
            var i = ch - 'a';  // номер буквы (0..25)
            
            if (cur.Next[i] == null) // если ветки нет — создаём
            {
                cur.Next[i] = new Node();
            }
            cur = cur.Next[i];
        }
        cur.IsWord = true;
    }

    public bool Search(string word)
    {
        var node = Walk(word);
        return node is { IsWord: true };
    }

    public bool StartsWith(string prefix)
    {
        return Walk(prefix) != null;
    }
    
    // Вспомогательная проходка по буквам, возвращает узел, где остановились (или null)
    private Node Walk(string s)
    {
        var cur = root;
        foreach (var ch in s)
        {
            int i = ch - 'a';
            cur = cur.Next[i];
            
            if (cur == null) 
                return null;
        }
        return cur;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */