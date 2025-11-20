namespace LeetCode.Easy.BinarySearchTree;

/// <summary>
/// 700. Search in a Binary Search Tree
/// Условие: найти узел со значением val в бинарном дереве поиска (BST). Вернуть поддерево с корнем в найденном узле, или null, если узел не найден.
///
/// Подход (рекурсия, используя свойства BST):
/// 1. Если root == null или root.val == val → возвращаем root.
/// 2. Если val < root.val → ищем в левом поддереве.
/// 3. Если val > root.val → ищем в правом поддереве.
///
/// Сложность:
/// - Время: O(h), где h — высота дерева (O(log n) для сбалансированного дерева)
/// - Память: O(h) — стек рекурсии
///
/// Пример:
/// Input:
///        4
///       / \
///      2   7
///     / \
///    1   3
///    val = 2
/// Output:
///      2
///     / \
///    1   3
/// Объяснение: нашли узел со значением 2 и вернули поддерево с корнем в этом узле
/// </summary>
public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null || root.val == val)
            return root;

        return SearchBST(val < root.val ? root.left : root.right, val);
    }
}