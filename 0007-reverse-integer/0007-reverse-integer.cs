public class Solution {
    public int Reverse(int x) {
       
       
       
        int number=0;
        int digit=0;
        
        int temp=0;
        
     
        
        
       while(x!=0){
           
           digit=x%10;
           x=x/10;
           temp=number;
           number = (number*10)+digit;
           if(number/10!=temp){
               return 0;
           }
           
           
       } 
        
        
      
        
        return number;
        
        
        
    }
}