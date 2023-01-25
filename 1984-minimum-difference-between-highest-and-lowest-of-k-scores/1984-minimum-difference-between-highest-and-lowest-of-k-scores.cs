public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        
        if(nums.Length<2){
return 0;
        }
        
        Array.Sort(nums);
        int diff = nums[nums.Length-1];
        
        
        for(int i=0,j=i+k-1;j<nums.Length;i++,j++){
            
            if(nums[j]-nums[i]<diff){
                diff = nums[j]-nums[i];
            }
            
            
        }
        
        return diff;
        
        
        
        
        
        
        
        
        
        
    }
}