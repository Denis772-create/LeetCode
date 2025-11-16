namespace LeetCode.Easy.BinaryTree;

public class IsSymmetricTree
{
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }
    
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode? left, TreeNode? right)
    {
        // оба пустые — симметрично
        if (left == null && right == null) return true;
        
        // один пустой, другой нет — не симметрично
        if (left == null || right == null) return false;
        
        // значения должны совпадать
        if (left.val != right.val) return false;
        
        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
}