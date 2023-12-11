public class Solution {
    public int FindSpecialInteger(int[] arr) {
        if(arr.Length<2){
            return 1;
        }
        int max = (int)(arr.Length / 4f);
        int j=0;
        
        for(int i=1;i<arr.Length;i++){
            
            if(arr[i-1]==arr[i]){
                j++;
                if(j>=max){
                    return arr[i];
                }
            }
            else{
                j=0;
            }
        }
        return 0;
        
    }
}