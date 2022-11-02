public class Solution {
    public int MajorityElement(int[] nums) {
        
      int count=1,num=nums[0];
        
        for(int i=1;i<nums.Length;i++){
            
            
            if(count==0){
                num=nums[i];
                count++;
                
            }
            else{
            if(nums[i]==num){
                count++;
            }
            
            else{
                
                count--;   
            }
        }
            
        }
            return num;
    }
    
    

}