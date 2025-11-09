namespace LeetCode.Medium.BinaryTree;

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