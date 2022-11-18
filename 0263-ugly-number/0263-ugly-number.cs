public class Solution {
    public bool IsUgly(int n) {
        bool ugly = false;
        if(n==1){
            
            return true;
        }
        if(n==0){
           
            return false;
        }
        
        while(n%2==0){
            n=n/2;
        }
        while(n%5==0){
            n=n/5;
        }
        while(n%3==0){
            n=n/3;
        }
        if(n==2||n==1||n==3||n==5){
            ugly = true;
        }
        return ugly;
        
    }
}