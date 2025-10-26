namespace LeetCode.Easy.BinaryTree;

/// <summary>
/// 104. Maximum Depth of Binary Tree
/// Условие: найти максимальную глубину бинарного дерева.
/// Глубина — это количество узлов на самом длинном пути от корня до листа.
///
/// Подход (DFS, рекурсия):
/// - Если узел null → глубина 0.
/// - Иначе глубина = 1 + max(глубина левого поддерева, глубина правого поддерева).
///
/// Сложность:
/// - Время: O(n), где n — количество узлов в дереве.
/// - Память: O(h), где h — высота дерева (стек рекурсии).
///
/// Пример:
/// Input:
///        3
///       / \
///      9  20
///         / \
///        15  7
///
/// Output: 3
/// Объяснение:
/// Путь 3 → 20 → 7 имеет длину 3, что является максимумом.
/// </summary>
public class Lc0104MaximumDepthOfBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public int MaxDepth(TreeNode? root)
    {
        // 1️⃣ Базовый случай: пустое дерево
        if (root == null)
            return 0;

        // 2️⃣ Рекурсивно считаем глубину поддеревьев
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);

        // 3️⃣ Текущая глубина = 1 (текущий узел) + максимум из поддеревьев
        return 1 + (left > right ? left : right);
    }
}