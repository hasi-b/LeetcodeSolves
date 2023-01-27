public class Solution {
    public int GetSum(int a, int b) {
        
        int temp =0;
        int temp1=0;
        int result=0;
        while(b!=0){
          temp =(a&b)<<1;
           a = a^b;
           b = temp;
           
            
            
        
            
            
            
            
            
        }
        return a^b;
        
    }
}