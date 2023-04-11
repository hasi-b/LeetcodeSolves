public class Solution {
    public string RemoveStars(string s) {
        
        Stack st = new Stack();
        
        for(int i=0;i<s.Length;i++){
            
            
            if(s[i]=='*'){
                
                st.Pop();
                
            }
            
            else{
                st.Push(s[i]);
            }
            
        }
        
        
        string sr = "";
        
        while(st.Count>0){
            
            sr = st.Pop()+sr;
            
            
            
        }
        
        
        return sr;
        
        
        
        
    }
}