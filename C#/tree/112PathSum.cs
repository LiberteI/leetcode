/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
/*
    time:  O(n)
    space: O(height) Imagine a path 5 → 2 → 4. When CheckTarget(4, ...) runs, the calls for 5 and 2 are still waiting for their results. So there are three active calls on the stack. Each uses constant space to hold its own arguments and local variables.
*/
public class PathSum112 {
    public bool HasPathSum(TreeNode root, int targetSum) {
        /*
            traverse from root to every sub nodes. 
        */
        return CheckTarget(root, targetSum, 0);
    }

    private bool CheckTarget(TreeNode root, int targetSum, int cur){
        if(root == null){
            return false;
        }

        int currentSum = cur + root.val;
        if(root.left == null && root.right == null){
            return currentSum == targetSum;
        }
        return CheckTarget(root.left, targetSum, currentSum) || CheckTarget(root.right, targetSum, currentSum);
       
    }
}