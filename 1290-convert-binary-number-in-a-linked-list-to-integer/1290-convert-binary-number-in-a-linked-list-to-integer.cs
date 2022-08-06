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
    public int GetDecimalValue(ListNode head) {
        
        int num =head.val;
        
        while(head.next!=null){
            
            num = num<<1 | head.next.val;
            head = head.next;
            
        }
        
        return num;
        
    }
}