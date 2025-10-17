namespace LeetCode.Easy.Binary_Tree;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxDepth(TreeNode root, int depth = 1)
    {
        if(root is null) return 0;
        if (root.left == null && root.right == null) return depth;
        
        int leftDepth = root.left != null ? MaxDepth(root.left, depth + 1) : depth;
        int rightDepth = root.right != null ? MaxDepth(root.right, depth + 1) : depth;

        return Math.Max(leftDepth, rightDepth);
    }
}