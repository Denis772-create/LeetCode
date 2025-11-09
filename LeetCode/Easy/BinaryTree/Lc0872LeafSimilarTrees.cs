namespace LeetCode.Easy.BinaryTree;

/// <summary>
/// 872. Leaf-Similar Trees
/// Условие: два дерева «похожи по листьям», если их последовательности листьев (слева направо) совпадают.
/// Нужно вернуть true/false.
///
/// Подход (DFS):
/// - Проходим дерево в глубину слева направо, добавляя в список значения только листьев (узел без детей).
/// - Строим последовательности для root1 и root2 и сравниваем их поэлементно.
///
/// Сложность:
/// - Время: O(n + m), где n и m — кол-во узлов в деревьях.
/// - Память: O(L1 + L2) для списков листьев (L — кол-во листьев).
///
/// Пример 1:
/// Input:
/// root1 = [3,5,1,6,2,9,8,null,null,7,4]
/// root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
/// Output: true
///
/// Пример 2:
/// Input:  root1 = [1,2,3], root2 = [1,3,2]
/// Output: false
/// </summary>
public class Lc0872LeafSimilarTrees
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        { this.val = val; this.left = left; this.right = right; }
    }

    public bool LeafSimilar(TreeNode? root1, TreeNode? root2)
    {
        var a = new List<int>();
        var b = new List<int>();
        
        DfsCollectLeaves(root1, a);
        DfsCollectLeaves(root2, b);
        
        if (a.Count != b.Count) 
            return false;

        for (var i = 0; i < a.Count; i++)
        {
            if (a[i] != b[i]) 
                return false;
        }
        return true;
    }

    private static void DfsCollectLeaves(TreeNode? node, List<int> leaves)
    {
        if (node == null) 
            return;
        
        if (node.left == null && node.right == null)
        {
            leaves.Add(node.val);
            return;
        }
        
        DfsCollectLeaves(node.left, leaves);
        DfsCollectLeaves(node.right, leaves);
    }
}