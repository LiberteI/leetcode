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
    time and space: both O(n)
 */
public class BinaryTreePostorderTraversal145 {
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();

        AddToList(root, list);

        return list;
    }

    private void AddToList(TreeNode root, IList<int> list){
        if(root == null){
            return;
        }
        
        AddToList(root.left, list);

        AddToList(root.right, list);

        list.Add(root.val);

    }
}