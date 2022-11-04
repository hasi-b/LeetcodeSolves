public class Solution {
    public string ReverseVowels(string s) {
        
        String t="";
        
        
        for(int i=0,j=s.Length-1;i<s.Length;){
            
            if(!(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'||s[i]=='A'||s[i]=='E'||s[i]=='I'||s[i]=='O'||s[i]=='U')){
                
                 t=t+s[i];
                i++;
                
            }
            
            else{
                
                
                while(!(s[j]=='a'||s[j]=='e'||s[j]=='i'||s[j]=='o'||s[j]=='u'||s[j]=='A'||s[j]=='E'||s[j]=='I'||s[j]=='O'||s[j]=='U')){
                    
                    
                    j--;
                }
                
                
                t=t+s[j];
                i++;
                j--;
                
                
            }
            
            
         
            
            
        }
        
        return t;
    }
}