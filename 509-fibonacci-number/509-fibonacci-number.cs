public class Solution {
    public int Fib(int n) {
        
        int fValue =0;
        int sValue = 1;
        int temp =0;
        
        
        if(n==0){
            return 0;
        }
        
        for(int i=0;i<n-1;i++){
            
            temp = sValue;
            sValue = sValue+fValue;
            fValue =temp;
            
            
            
        }
        return sValue;
        
        
        
    }
}