namespace LeetCode.Easy.BinaryTree;

/// <summary>
/// 101. Symmetric Tree
/// Условие: проверить, является ли бинарное дерево симметричным относительно корня.
///
/// Подход (рекурсия):
/// 1. Дерево симметрично, если левое и правое поддеревья зеркальны.
/// 2. Два узла зеркальны, если:
///    - Оба null → симметрично.
///    - Один null, другой нет → не симметрично.
///    - Значения равны И left.left зеркально right.right И left.right зеркально right.left.
///
/// Сложность:
/// - Время: O(n), где n — количество узлов
/// - Память: O(h), где h — высота дерева (стек рекурсии)
///
/// Пример:
/// Input:
///         1
///        / \
///       2   2
///      / \ / \
///     3  4 4  3
/// Output: true
/// Объяснение: дерево симметрично относительно корня
/// </summary>
public class IsSymmetricTree
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }
    
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode? left, TreeNode? right)
    {
        // оба пустые — симметрично
        if (left == null && right == null) return true;
        
        // один пустой, другой нет — не симметрично
        if (left == null || right == null) return false;
        
        // значения должны совпадать
        if (left.val != right.val) return false;
        
        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
}