public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool flag1 = false;
        bool flag2 = false;
        if(nums.Length<2){
            return true;
        }
        for(int i=0;i<nums.Length-1;i++){
            
            if(nums[i]>nums[i+1]){
                flag1=false;
                break;
            }
            else{
                flag1 = true;
            }
        }
        for(int j=0;j<nums.Length-1;j++){
             if(nums[j]<nums[j+1]){
                flag2=false;
                break;
            }
            else{
                flag2 = true;
            }
        }
        
        if(flag1 == true || flag2 == true){
             return true;
        }
        else{
            return false;
        }
    }
}