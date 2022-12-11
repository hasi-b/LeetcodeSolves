public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        

        int[] newArr = new int[nums.Length];

        for(int i=0,j=nums.Length-1,k=newArr.Length-1;i<=j;){

            int neg= (int)Math.Pow(nums[i],2);
            int pos= (int)Math.Pow(nums[j],2);

            if(neg>pos){
                
                newArr[k]=neg;
                k--;
                i++;

            }
            else{
                newArr[k]=pos;
                k--;
                j--;
            }

        }
        
        
        
        return newArr;
        
        
    }
}