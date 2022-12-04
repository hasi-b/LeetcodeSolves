public class Solution {
    public int MinimumAverageDifference(int[] nums) {
        
        long sum =0;
        int index=0;
        
        if(nums.Length<=1){
            return 0;
        }
        
        for(int i=0;i<nums.Length;i++){
            
            sum = sum + nums[i];
            
        }
        
        
        
        long avDiff= -1;
        long newSum =0;
        
        
        for(int i=0;i<nums.Length;i++){
            
            
            newSum = newSum+nums[i];
            long tempSum = sum-newSum;
            long avgDiffIndex =0;
            if((nums.Length-(i+1))==0){
                  avgDiffIndex = Math.Abs((newSum/(i+1))-0);
            }
            else{
            avgDiffIndex = Math.Abs((newSum/(i+1))-(tempSum/(nums.Length-(i+1))));
            }
            
            if(i==0){
                
                avDiff=avgDiffIndex;
                
            }
              
                
                 if(avgDiffIndex<avDiff){
                    avDiff = avgDiffIndex;
                    index = i;
                }
            
        }
        
        return index;
        
    }
}