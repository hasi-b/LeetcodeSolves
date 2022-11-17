public class Solution {
    public int MissingNumber(int[] nums) {
        
        int sum1=0;
        int sum2=0;
        
        for(int i=0;i<nums.Length;i++){
            
            sum1=sum1+nums[i];
            sum2=sum2+i;
            
        }
        sum2=sum2+nums.Length;
        return sum2-sum1;
    }
}