namespace LeetCode.Medium.BinaryTreeDFS;

public class Solution134
{
    // Определение узла бинарного дерева
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    public int GoodNodes(TreeNode root)
    {
        // Корень всегда "good".
        // Запускаем DFS, передавая "максимум на пути" = значение корня.
        return Dfs(root, root.val);
    }

    // Рекурсивная функция: возвращает, сколько "good" узлов в поддереве node,
    // если по пути сверху максимальное значение равно maxSoFar.
    private int Dfs(TreeNode? node, int maxSoFar)
    {
        // База: дошли до пустой ветки — хороших узлов нет.
        if (node == null) return 0;
        
        // Текущий узел "good", если его значение >= максимуму на пути.
        var isGood = node.val >= maxSoFar ? 1 : 0;
        
        // Обновляем максимум на пути: возможно, текущий узел — новый максимум.
        var newMax = Math.Max(maxSoFar, node.val);
        
        // Идём влево и вправо, передавая обновлённый максимум.
        var leftGood = Dfs(node.left, newMax);
        var rightGood = Dfs(node.right, newMax);
        
        // Возвращаем общее количество "good": текущий + слева + справа.
        return isGood + leftGood + rightGood;
    }
}