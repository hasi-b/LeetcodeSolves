public class Solution {
    public bool IsPalindrome(int x) {
        
        long n =x;
        if(x<0){
            return false;
        }
        long digit=0;
        long x2=0;
        while(n>0){
            digit = n%10;
            n=n/10;
             Console.WriteLine(n);
            x2=10*x2;
            x2=x2+digit;
            
            
        }
        Console.WriteLine("x2"+x2);
        return x==x2;
        
        
    }
}