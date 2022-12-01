public class Solution {
    public bool HalvesAreAlike(string s) {
        
        
        int countF =0;
        int countL =0;
        
        for(int i=0,j=s.Length-1;i<j;i++,j--){
            
            if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'||s[i]=='A'||s[i]=='E'||s[i]=='I'||s[i]=='O'||s[i]=='U'){
                countF++;
            }
            if(s[j]=='a'||s[j]=='e'||s[j]=='i'||s[j]=='o'||s[j]=='u'||s[j]=='A'||s[j]=='E'||s[j]=='I'||s[j]=='O'||s[j]=='U'){
                countL++;
            }
            
            
            
        }
        
        return countF==countL;
    }
}