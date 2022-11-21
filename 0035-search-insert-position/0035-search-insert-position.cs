public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        
        int l=0;
        int r=nums.Length-1;
        
        int mid = l+(r-l)/2;
        
        
        while(l<r){
            
            if(target>nums[mid]){
                
                l=mid+1;
            }
            else if(target<nums[mid]){
                
                r=mid-1;
            }
            else{
                return mid;
            }
            mid = l+(r-l)/2;
        }
        
        
        
        if(nums[mid]<target){
            return mid+1;
        }
        else{
            return mid;
        }
    }
}