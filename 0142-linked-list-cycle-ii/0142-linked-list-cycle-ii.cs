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
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        
        
        int flag=0;
        ListNode fast=head;
        ListNode slow=head;
        ListNode start = head;
        while(fast!=null && fast.next!=null){
            
            slow=slow.next;
            fast=fast.next.next;
            
            if(slow==fast){
                
                flag =1;
                break;
            }
            
            
        }
        
        if(flag==1){
            
            while(slow!=start){
                
               slow=slow.next;
                start=start.next;
                
            }
            return slow;
            
            
        }
        
        
        return null;
        
        
        
    }
}