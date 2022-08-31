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
    public ListNode DeleteMiddle(ListNode head) {
        
        
        
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = new ListNode();
        ListNode nxt = new ListNode();
        
        
        if(head.next==null){
            head = null;
            
        }
        
        else{
        
        while(fast!= null && fast.next!= null){
            prev = slow;
            slow = slow.next;
            nxt = slow.next;
            fast=fast.next;
            fast=fast.next;
            
        }
        prev.next = nxt;
            
        }
        
        
        return head;
        
        
        
        
        
    
        
    }
}