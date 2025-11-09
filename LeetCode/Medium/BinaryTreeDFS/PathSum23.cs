namespace LeetCode.Medium.BinaryTreeDFS;

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