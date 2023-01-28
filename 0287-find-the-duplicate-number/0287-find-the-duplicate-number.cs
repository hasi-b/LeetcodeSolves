public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow =0;
        int fast =0;
        int start =0;
        
        while(1==1){
            
            slow = nums[slow];
            fast= nums[fast];
            fast = nums[fast];
            
            if(slow == fast){
                
                break;
            }
            
        }
        
        
        while(start!=slow){
            
            
            start=nums[start];
            slow = nums[slow];
            
        }
        return slow;
        
    }
}