using System;

namespace LeetCode.Medium.BinarySearchTree;

/// <summary>
/// 450. Delete Node in a BST
/// Условие: удалить узел со значением key из бинарного дерева поиска (BST) и вернуть корень обновлённого дерева.
///
/// Подход:
/// 1. Ищем узел по правилам BST (key < val → идём влево, key > val → вправо).
/// 2. При удалении рассматриваем три случая:
///    - Нет детей → возвращаем null.
///    - Один ребёнок → возвращаем его.
///    - Два ребёнка → находим минимальный узел в правом поддереве (inorder successor),
///      копируем его значение в удаляемый узел, удаляем successor.
///
/// Сложность:
/// - Время: O(h), где h — высота дерева
/// - Память: O(h) — стек рекурсии
///
/// Пример:
/// Input:
///        5
///       / \
///      3   6
///     / \   \
///    2   4   7
/// key = 3
/// Output:
///        5
///       / \
///      4   6
///     /     \
///    2       7
/// Объяснение: узел 3 заменён на 4 (минимальный в правом поддереве)
/// </summary>
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

public class Soalution
{
    public TreeNode? DeleteNode(TreeNode? root, int key)
    {
        // 🔹 1. Базовый случай: если дерево пустое — просто вернуть null
        if (root == null)
            return null;

        // 🔹 2. Идём искать нужный узел, как в обычном BST:
        if (key < root.val)
        {
            // ключ меньше — значит, целевой узел в ЛЕВОМ поддереве
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val)
        {
            // ключ больше — значит, целевой узел в ПРАВОМ поддереве
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            // 🔹 3. Нашли узел, который нужно удалить

            // --- Случай 1: нет левого поддерева ---
            if (root.left == null)
                // Просто возвращаем правое поддерево — оно займёт место удалённого узла
                return root.right;

            // --- Случай 2: нет правого поддерева ---
            if (root.right == null)
                // Возвращаем левое поддерево
                return root.left;

            // --- Случай 3: есть оба поддерева ---
            // Нам нужно сохранить порядок BST.
            // Для этого найдём "inorder successor" — минимальный узел в правом поддереве.
            TreeNode successor = FindMin(root.right!);

            // Копируем его значение в текущий узел (мы "замещаем" удаляемый узел)
            root.val = successor.val;

            // Теперь нужно удалить узел, значение которого мы только что скопировали,
            // чтобы не было дублей. Этот узел точно находится в правом поддереве.
            root.right = DeleteNode(root.right, successor.val);
        }

        // 🔹 4. Возвращаем (возможно обновлённый) корень поддерева
        return root;
    }

    // Вспомогательная функция: найти минимальный элемент в дереве
    private TreeNode FindMin(TreeNode node)
    {
        // идём максимально влево, пока можем — там минимальное значение
        while (node.left != null)
            node = node.left;

        return node;
    }
}
