namespace LeetCode.Medium.BinaryTreeDFS;

/// <summary>
/// 437. Path Sum III
/// Условие: найти количество путей в бинарном дереве, сумма значений которых равна targetSum.
/// Путь может начинаться и заканчиваться в любом узле, но должен идти вниз (от родителя к потомку).
///
/// Подход (рекурсия с двумя функциями):
/// 1. PathSum: для каждого узла считает пути, начинающиеся в нём, и рекурсивно обрабатывает поддеревья.
/// 2. CountFrom: считает пути, начинающиеся в конкретном узле и идущие вниз.
///
/// Сложность:
/// - Время: O(n²) в худшем случае (для каждого узла проверяем все пути вниз)
/// - Память: O(h), где h — высота дерева (стек рекурсии)
///
/// Пример:
/// Input:
///        10
///       /  \
///      5   -3
///     / \    \
///    3   2   11
///   / \   \
///  3  -2   1
/// targetSum = 8
/// Output: 3
/// Объяснение: пути [5,3], [5,2,1], [-3,11] имеют сумму 8
/// </summary>
public class PathSum23
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    public int PathSum(TreeNode root, int targetSum)
    {
        if (root is null) return 0;
        
        int fromHere   = CountFrom(root, targetSum);         // пути, стартующие в текущем узле
        int fromLeft   = PathSum(root.left, targetSum);
        int fromRight  = PathSum(root.right, targetSum);
        
        return fromHere + fromLeft + fromRight;
    }

    // Считает количество путей, ИДУЩИХ ВНИЗ и НАЧИНАЮЩИХСЯ ИМЕННО В ЭТОМ УЗЛЕ,
    // сумма которых равна 'need'.
    private int CountFrom(TreeNode? node, long need)
    {
        if (node == null) return 0;

        // Берём этот узел в текущий путь: уменьшаем требуемую сумму
        long rest = need - node.val;

        int count = 0;
        // Если после взятия узла требуемая сумма стала 0 — найден валидный путь
        if (rest == 0) count++;

        // Продолжаем вниз влево и вправо
        count += CountFrom(node.left,  rest);
        count += CountFrom(node.right, rest);

        return count;
    }
}