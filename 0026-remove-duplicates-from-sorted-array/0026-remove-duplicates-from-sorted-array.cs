public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        
        int count =0;
        int checkNum=nums[0];
        int temp;
        
        for(int i=1,j=1;i<nums.Length;i++){
            
            if(nums[i]!=checkNum){
                count++;
                checkNum=nums[i];
                temp=nums[i];
                nums[i]=nums[j];
                nums[j] = temp;
                
                j++;
                
            }
            
            
        }
        return count+1;
    }
}