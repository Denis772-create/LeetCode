namespace LeetCode.Medium.BinaryTree;

/// <summary>
/// 199. Binary Tree Right Side View
/// Условие: вернуть список значений узлов, которые видны при взгляде на бинарное дерево справа.
///
/// Подход (BFS по уровням):
/// - Проходим дерево по уровням с помощью очереди.
/// - На каждом уровне добавляем в результат значение последнего узла (самый правый на этом уровне).
///
/// Сложность:
/// - Время: O(n), где n — число узлов.
/// - Память: O(w), где w — максимальная ширина дерева (очередь).
///
/// Пример:
/// Input:
///        1
///       / \
///      2   3
///       \   \
///        5   4
///
/// Output: [1, 3, 4]
/// Объяснение:
/// - Первый уровень → 1
/// - Второй уровень → 3 (правее 2)
/// - Третий уровень → 4 (правее 5)
/// </summary>
public class Lc0199BinaryTreeRightSideView
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

    public IList<int> RightSideView(TreeNode? root)
    {
        var result = new List<int>();
        if (root == null)
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // 1️⃣ Обходим уровни
        while (queue.Count > 0)
        {
            var levelSize = queue.Count;

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                // 2️⃣ Если последний на уровне → добавляем в результат
                if (i == levelSize - 1)
                    result.Add(node.val);

                // 3️⃣ Добавляем потомков в очередь
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        return result;
    }
}