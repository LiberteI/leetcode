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
public class ConvertSortedArraytoBSTree108 {
    public TreeNode SortedArrayToBST(int[] nums) {
        /*
            - use recursion to start from the middle. use it as root
            - get left half, attach to the left of root. get right half and attach to the right of the root
            - recursively repeate the steps
        */
        TreeNode root = Build(nums, 0, nums.Length - 1);

        PrintArray(root);
        return root;
    }
    private void PrintArray(TreeNode root){
        // traverse from root.
    }

    private TreeNode Build(int[] nums, int leftIdx, int rightIdx){
        // base case: return null
        if(leftIdx > rightIdx){
            return null;
        }
        int midIdx = (leftIdx + rightIdx) / 2;

        // definition has default values. val means the value the nums is holding.
        TreeNode root = new TreeNode(nums[midIdx], null, null);

        // recursively assign left or right of the root
        // cut all right nodes for lefts
        root.left = Build(nums, leftIdx, midIdx - 1);
        // cut all left nodes for rights
        root.right = Build(nums, midIdx + 1, rightIdx);

        return root;
    }
}