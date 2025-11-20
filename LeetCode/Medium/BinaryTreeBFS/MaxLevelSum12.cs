namespace LeetCode.Medium.BinaryTree;

/// <summary>
/// 1161. Maximum Level Sum of a Binary Tree
/// Условие: найти уровень бинарного дерева с максимальной суммой значений узлов.
/// Если несколько уровней имеют одинаковую максимальную сумму, вернуть наименьший уровень.
///
/// Подход (BFS по уровням):
/// 1. Используем BFS для обхода дерева по уровням.
/// 2. На каждом уровне суммируем значения всех узлов.
/// 3. Отслеживаем уровень с максимальной суммой.
///
/// Сложность:
/// - Время: O(n), где n — количество узлов
/// - Память: O(w), где w — максимальная ширина дерева (очередь)
///
/// Пример:
/// Input:
///        1
///       / \
///      7   0
///     / \
///    7  -8
/// Output: 2
/// Объяснение:
/// - Уровень 1: сумма = 1
/// - Уровень 2: сумма = 7 + 0 = 7
/// - Уровень 3: сумма = 7 + (-8) = -1
/// Максимум на уровне 2
/// </summary>
public class MaxLevelSum12
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }

    public int MaxLevelSum(TreeNode root)
    {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        int level = 0;
        long bestSum = long.MinValue;
        int bestLevel = 1;

        while (q.Count > 0)
        {
            level++;
            int size = q.Count;
            long sum = 0;

            for (int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                sum += node.val;
                
                if (node.left  != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            if (sum > bestSum)
            {
                bestSum = sum;
                bestLevel = level;
            }
        }
        
        return bestLevel;
    }
}