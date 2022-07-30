public class Solution {
    public int LengthOfLastWord(string s) {
        char d = ' ';
        int count =0;
        for(int i=0;i<s.Length;i++){
            
            
            if(s[i]!=d){
                
                if(i!=0){
                    if(s[i-1]==d){
                        count =0;
                    }
                }
                
                count++;
                
            }
          
           
            
        }
        return count;
    }
}