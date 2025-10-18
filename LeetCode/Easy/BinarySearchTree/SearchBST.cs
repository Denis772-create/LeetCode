namespace LeetCode.Easy.BinarySearchTree;

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null || root.val == val)
            return root;

        return SearchBST(val < root.val ? root.left : root.right, val);
    }
}


/*
 * 1. Рекурсивно берем и смотрим
 * 2. текущий корень меньше указанного значения? берем левый и идем дальше
 * 3. и наоборот елси больше
 * 4. если равен возвращаем результат
 */