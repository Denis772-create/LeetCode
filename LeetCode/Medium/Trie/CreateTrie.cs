namespace LeetCode.Medium.Trie;

/// <summary>
/// 208. Implement Trie (Prefix Tree)
///
/// Идея:
/// Trie (дерево префиксов) — это структура данных, которая хранит слова по буквам.
/// Каждый узел может иметь до 26 детей (для 'a'..'z') и флажок IsWord,
/// который показывает, что здесь заканчивается полное слово.
///
/// Основные операции:
/// 1️⃣ Insert(word) — вставить слово по символам.
/// 2️⃣ Search(word) — проверить, есть ли слово полностью.
/// 3️⃣ StartsWith(prefix) — проверить, есть ли слова с данным префиксом.
///
/// Пример:
/// Insert("apple")
/// Search("apple") → true
/// Search("app") → false
/// StartsWith("app") → true
///
/// Сложность:
/// - Время:
///   • Insert: O(L)
///   • Search: O(L)
///   • StartsWith: O(L)
///   (где L — длина слова/префикса)
/// - Память: O(26 * N) в худшем случае (N — суммарная длина всех слов)
/// </summary>
public class Trie
{
    /// <summary>
    /// Узел Trie — хранит ссылки на детей и флаг конца слова
    /// </summary>
    private class Node
    {
        public readonly Node[] Next = new Node[26]; // дети по буквам a..z
        public bool IsWord;                         // флажок "это слово"
    }

    private readonly Node _root = new Node();

    /// <summary>
    /// Вставка слова в Trie
    /// </summary>
    public void Insert(string word)
    {
        var cur = _root;
        foreach (var ch in word)
        {
            int i = ch - 'a'; // индекс буквы (0..25)
            if (cur.Next[i] == null)
                cur.Next[i] = new Node();

            cur = cur.Next[i];
        }

        // отмечаем, что это конец слова
        cur.IsWord = true;
    }

    /// <summary>
    /// Проверка, содержится ли слово полностью в Trie
    /// </summary>
    public bool Search(string word)
    {
        var node = Walk(word);
        return node is { IsWord: true };
    }

    /// <summary>
    /// Проверка, есть ли слова с данным префиксом
    /// </summary>
    public bool StartsWith(string prefix)
    {
        return Walk(prefix) != null;
    }

    /// <summary>
    /// Вспомогательная функция: двигается по Trie согласно строке
    /// и возвращает узел, на котором остановились (или null, если не дошли)
    /// </summary>
    private Node Walk(string s)
    {
        var cur = _root;
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
