/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

 /*
    time: O(n)
    space:O(n)

    check null before accessing a property
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        /*
            two pointer
            add current elements. result = mod 10. add 1 to the next

            case 1: neither is null
            case 2: either is null
            
            generic: should plus one check
        */
        ListNode init = new ListNode();
        ListNode dummy = init;

        int carry = 0;
        while(l1 != null || l2 != null){
            
            if(l1 == null && l2 != null){
                int curSum = l2.val + carry;
                int curDigit = curSum % 10;
                init.next = new ListNode(curDigit, null);
                init = init.next;
                carry = curSum > 9 ? 1 : 0;
            }
            else if(l2 == null && l1 != null){
                int curSum = l1.val + carry;
                int curDigit = curSum % 10;
                init.next = new ListNode(curDigit, null);
                init = init.next;
                carry = curSum > 9 ? 1 : 0;
            }
            else{ // if neither is null:
                int curSum = l1.val + l2.val + carry;
                int curDigit = curSum % 10;
                init.next = new ListNode(curDigit, null);
                init = init.next;
                carry = curSum > 9 ? 1 : 0;
            }
            if(l1 != null){
                l1 = l1.next;
            }
            if(l2 != null){
                l2 = l2.next;
            }

        }

        if(carry == 1){
            init.next = new ListNode(1, null);
        }
        return dummy.next;
    }
}