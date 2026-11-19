/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
/*
    Time: O(n)
    space:O(1)

    Space O(n) solution: use HashSet

    note: check node's current nullity before accessing its property.;
*/
public class LinkedlistCycle141 {
    public bool HasCycle(ListNode head) {
        /*
            use two pointer: 
            slow traverse 1 node per time
            fast traverse 2 nodes per time
            if there is a loop slow will eventually fast
        */
        if(head == null){
            return false;
        }
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;

            if(fast == slow){
                return true;
            }
        }
        return false;
    }
}