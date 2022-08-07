public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp =0;
        
        for(int i=0,j=0;i<nums.Length&&j<nums.Length;){
            
            
            if(nums[i]==0){
                
                i++;
                
            }
            else{
                temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                
                j++;
                i++;
                
                
                
                
            }
      
            
            
            
        }
        
    }
}