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
    time: O(n)
    Space:O(h)
 */
public class PathSumII113 {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        /*
            use recursion to traverse from root to the last leaf.
        */
        IList<IList<int>> list = new List<IList<int>>();

        CheckPaths(root, list, targetSum, 0, new List<int>());
        return list;
    }

    private void CheckPaths(TreeNode node, IList<IList<int>> list, int targetSum, int cur, IList<int> progress){
        if(node == null){
            return;
        }

        cur += node.val;
        progress.Add(node.val);
        
        if(node.left == null && node.right == null && cur == targetSum){
            list.Add(new List<int>(progress)); // list.Add(progress); reference the shared list while new list creates a copy
            // this early return will miss a clean up
            // return;
        }

        CheckPaths(node.left, list, targetSum, cur, progress);

        CheckPaths(node.right, list, targetSum, cur, progress);
        
        // backtracking clean up. clean up last visited node
        progress.RemoveAt(progress.Count - 1);
    }
}