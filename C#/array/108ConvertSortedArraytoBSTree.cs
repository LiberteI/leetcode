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
    time: O(n) because all element is reached
    space: 
        Build O(Logn): Recursion stack for balanced tree traversal: logn
        others: O(n) because all elements got copied
 */

/*
      4
     / \
    2   6
   / \
  1   3

Preorder means: root -> left -> right 4 2 1 3 6
Inorder means:  left -> root -> right 1 2 3 4 6
Postorder means:left -> right-> root  1 3 2 6 4
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
        /*
            - take the root node, write its left, right to the array.
            - recursively take left root node and right node to write in.
            - base case is when the current root has no children
        */

        // create a list to store items
        List<int> list = new List<int>();
        // recursively call function to 1. store current var. 2. traverse preorderly to use next root
        Collect(root, list);

        // separate every element with ","
        Console.WriteLine(string.Join(",", list));
    }

    private void Collect(TreeNode root, List<int> list){
        // base case
        if(root == null){
            return;
        }

        /*
            change the order of this part will result in different traversal orders
            currently it is preorder
        */
        // add current root value
        list.Add(root.val);
        // add left
        Collect(root.left, list);
        // add right
        Collect(root.right, list);
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