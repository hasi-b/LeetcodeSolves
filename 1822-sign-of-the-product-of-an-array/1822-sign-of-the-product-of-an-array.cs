public class Solution {
    public int ArraySign(int[] nums) {
        
        
        int mul=1;
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                return 0;
            
            }
            else if(nums[i]>0){
                mul= mul*1;
            }
            else{
                mul=mul*-1;
            }
            
                
        }
        
        
       
            return mul;
        
        
        
        
        
    }
}