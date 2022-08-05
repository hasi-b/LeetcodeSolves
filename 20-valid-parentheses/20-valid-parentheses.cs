public class Solution {
    public bool IsValid(string s) {
        
        // ((({{{[]}}})))
        
        
        Stack<char> myStack = new Stack<char>();
        
        
        
        for(int i=0;i<s.Length;i++){
            
            
            if(myStack.Count>0){
                
                if((myStack.Peek()=='(' && s[i]==')') || (myStack.Peek()=='[' && s[i]==']')||(myStack.Peek()=='{' && s[i]=='}') ){
                    
                    
                    myStack.Pop();
                }
                else{
                    myStack.Push(s[i]);
                }
                
                
                
            }
            else{
                
                myStack.Push(s[i]);
            }
            
            
           
            
        }
        
        if(myStack.Count==0){
            return true;
        }
        else{
            return false;
        }
        
    }
}