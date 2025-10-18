namespace LeetCode.Easy.BinaryTree;

/// <summary>
/// 104. Maximum Depth of Binary Tree
/// Условие: найти максимальную глубину бинарного дерева.
///
/// Подход (DFS): глубина узла = 1 + max(depth(left), depth(right)). Пустое дерево — 0.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(h) — глубина стека рекурсии
/// </summary>
public class Lc0104MaximumDepthOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        { this.val = val; this.left = left; this.right = right; }
    }

    public int MaxDepth(TreeNode? root)
    {
        if (root == null) return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return 1 + (left > right ? left : right);
    }
}


