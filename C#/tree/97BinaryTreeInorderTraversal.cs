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
    time: O(n): if all nodes are appended to the left so every node is reached
    space:O(n): nodes are copied into list
*/
public class BinaryTreeInorderTraversal97 {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();

        AddToList(root, list);

        return list;
    }

    private void AddToList(TreeNode root, IList<int> list){
        if(root == null){
            return;
        }

        AddToList(root.left, list);

        list.Add(root.val);

        AddToList(root.right, list);
    }
}