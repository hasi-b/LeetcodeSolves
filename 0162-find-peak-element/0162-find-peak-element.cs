public class Solution {
    public int FindPeakElement(int[] nums) {
        int index=0;
      
        if(nums.Length<2){
            return 0;
        }
        for(int i=0;i<nums.Length;i++){
            if(i>0 && i<nums.Length-1 ){
                if(nums[i-1]<nums[i] && nums[i]>nums[i+1]){
                    index =i;  
                }
               
            }
            else{
                 if(i==0){
                     if(nums[i]>nums[i+1]){
                           return i;
                     }
              
            }
            if(i==nums.Length-1){
                if(nums[i-1]<nums[i]){
                  return i;  
                }
                
            }
            }
            
        }
        return index;
    }
}