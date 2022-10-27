public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int sum=nums[0];
        int max=sum;
        
        for(int i=1,j=0;i<nums.Length;i++){
            
           
            if(sum>=nums[i]){
                 
                
                sum = sum+nums[i];
                
                if(sum>max){
                    max=sum;
                }
                
            }
            else{
                
                
                
                if(sum+nums[i]<nums[i]){
                     sum=nums[i];
                    
                }
                
               else{
                   
                  sum=sum+ nums[i];
               }
                if(sum>max){
                    max=sum;
                }
                
            }
            
            
           
            
            
            
        }
        return max;
        
        
    }
}