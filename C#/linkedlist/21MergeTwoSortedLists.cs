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
    time O(n)
    space O(n). to make it O(1), use list1 and list2's nodes instead of creating using new

    note:
    !(list1cur == null && list2cur == null) => list1cur != null || list2cur != null
    
 */
public class MergeTwoSortedLists21 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        /*
            - use 2 pointer
            - start at heads
            - compare each while advancing

            list1 = [1,2,4], list2 = [1,3,4]

            list1   list2   action
            1       1       1 = 1; advance list1; list3 = 1;
            2       1       2 > 1; advance list2; list3.next = 1
            2       3       3 > 2; advance list1; list3.next = 3
            4       3       4 > 3; advance list2; list3.next = 3
            4       4       4 = 4; advance list1; list3.next = 4
            null    4       list1 is null. list2 is not null; list3.next = 4 advance list2
            null    null    both are null. exit
        */
        ListNode list1cur = list1;
        ListNode list2cur = list2;
        
        ListNode list3cur = new ListNode();
        ListNode list3head = list3cur;

        while(!(list1cur == null && list2cur == null)){
            if(list1cur == null){
                list3cur.next = new ListNode(list2cur.val);
                list2cur = list2cur.next;
                list3cur = list3cur.next;
                continue;
            }
            if(list2cur == null){
                list3cur.next = new ListNode(list1cur.val);
                list1cur = list1cur.next;
                list3cur = list3cur.next;
                continue;
            }

            if(list1cur.val <= list2cur.val){
                list3cur.next = new ListNode(list1cur.val);
                list1cur = list1cur.next;
            }
            else{
                list3cur.next = new ListNode(list2cur.val);
                list2cur = list2cur.next;
            }

            list3cur = list3cur.next;

        }

        return list3head.next;
    }
}