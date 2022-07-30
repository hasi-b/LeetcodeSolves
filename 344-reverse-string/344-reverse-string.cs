public class Solution {
    public void ReverseString(char[] s) {
        char temp;
        for(int i=0,j=s.Length-1;i<s.Length/2;i++,j--){
            
            temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            
        }
        
        
        
    }
}