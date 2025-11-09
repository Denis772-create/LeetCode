namespace LeetCode.Medium.BST;

/// <summary>
/// 450. Delete Node in a BST
/// 
/// Условие:
/// Дано бинарное дерево поиска (BST) и ключ key.
/// Нужно удалить узел с этим значением и вернуть обновлённый корень.
/// 
/// Подход:
/// 1️⃣ Сначала находим узел по правилу BST:
///     - если key < node.val → ищем слева
///     - если key > node.val → ищем справа
///     - иначе нашли нужный узел
///
/// 2️⃣ Удаляем найденный узел:
///     - Если нет детей → возвращаем null
///     - Если один ребёнок → возвращаем его напрямую
///     - Если два ребёнка:
///         → ищем минимальный узел в правом поддереве
///         → копируем его значение в текущий узел
///         → удаляем этот минимальный узел справа
///
/// Сложность:
/// - Время: O(h), где h — высота дерева
/// - Память: O(h) (из-за рекурсии)
///
/// Пример:
/// root = [5,3,6,2,4,null,7], key = 3
/// после удаления: [5,4,6,2,null,null,7]
/// </summary>
public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}

public class Lc0450DeleteNodeInBST
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null)
            return null;

        // 1️⃣ Ищем узел для удаления
        if (key < root.val)
            root.left = DeleteNode(root.left, key);
        else if (key > root.val)
            root.right = DeleteNode(root.right, key);
        else
        {
            // 2️⃣ Нашли узел → три случая

            // Случай 1: нет детей
            if (root.left == null && root.right == null)
                return null;

            // Случай 2: один ребёнок
            if (root.left == null)
                return root.right;
            if (root.right == null)
                return root.left;

            // Случай 3: два ребёнка
            var minNode = FindMin(root.right);
            root.val = minNode.val; // копируем значение
            root.right = DeleteNode(root.right, minNode.val); // удаляем дубликат
        }

        return root;
    }

    /// <summary>
    /// Возвращает минимальный узел в поддереве
    /// (самый левый элемент)
    /// </summary>
    private TreeNode FindMin(TreeNode node)
    {
        while (node.left != null)
            node = node.left;
        return node;
    }
}
