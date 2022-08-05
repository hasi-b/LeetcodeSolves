public class Solution {
    public string RemoveDuplicates(string s) {
        
        Stack mystack = new Stack();
        
       
        
        for(int i =0;i<s.Length;i++){
            
            if(mystack.Count>0){

            if((char)mystack.Peek() == s[i]){
                mystack.Pop();
            }
                else{
                    mystack.Push(s[i]);
                }
            
            }
            else{
                mystack.Push(s[i]);
            }
            
            
        }
        
        
        
      char[] result = new char[mystack.Count];
        
        for(int i = mystack.Count-1;i>=0;i--){
            result[i] = (char)mystack.Pop();
        }
        
        return new string(result);
        
        
    }
}