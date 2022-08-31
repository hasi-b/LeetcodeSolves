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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = slow;
        ListNode nxt = slow.next;
        
        if(head.next==null){
            
            head = null;
        }
        else{
        while(n>0 && fast!=null){
            
            
            fast=fast.next;
            n--;
           
        }
        while(fast!=null){
            prev=slow;
            
            slow = slow.next;
            nxt = slow.next;
            fast = fast.next;

        }
        prev.next = nxt;
            if(slow==head){
                head=head.next;
            }
            
    }
        return head;
        
    }
}