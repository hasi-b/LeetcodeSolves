public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int [] result = new int[2];
        
        
        for(int i=0,j=numbers.Length-1;i<j;){
            
            
            if(numbers[i]+numbers[j]==target){
                
                result[0] = i+1;
                result[1] = j+1;
                break;
                
            }
            else if(numbers[i]+numbers[j]>target){
                
                j--;
                
            }
            else if(numbers[i]+numbers[j]<target){
                
                i++;
                
            }
            
        }
         return result;
    }
}