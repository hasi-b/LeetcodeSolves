public class Solution {
    public int MaxProduct(int[] nums) {
        //Array.Sort(nums);
        //return (nums[nums.Length-1]-1)*(nums[nums.Length-2]-1);


        int max=-1;
        int secondMax=-1;
        for(int i=0;i<nums.Length;i++){
            if(max<=nums[i]){
                secondMax=max;
                max=nums[i];
            }
            else{
                if(secondMax<=nums[i]){
                    secondMax=nums[i];
                }
            }
        }
        return (max-1)*(secondMax-1);
    }
}