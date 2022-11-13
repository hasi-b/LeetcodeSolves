public class Solution {
    public string ReverseWords(string s) {
        
       bool checker = false;
        
        String a="";
        String sentence="";
        
        Stack<char> myStack = new Stack<char>();
        
        for(int i=0;i<s.Length;i++){
            
            
            if(i+1<s.Length){
                
                
                 if(i==0 && s[i]==' '){
               
               
           }
            else if(s[i]==' '&& s[i+1]== ' '){
                
                
            }
                else if(s[i]==' '&& i==s.Length-1){

                
                }
               
            else{
                  Console.WriteLine(s[i]);
                
               if(s[i]==' ' && checker ==false){
                   
               }
                else{
                checker = true;
                myStack.Push(s[i]);
                }
                
            }
                 
                
                
                
            }
            else{
                
                if(s[i]!=' '){
                    
                    myStack.Push(s[i]);
                }
            }
            
            
          
            
           
        }
       
       
        
        for(int i=0;i<s.Length;i++){
            
           if(myStack.Count>0){
            if(myStack.Peek()==' '){
                
                sentence = sentence +a+" ";
                a="";
                myStack.Pop();
               
            }
            else{
                
            a=myStack.Pop()+a;
            }
            
        }
        }
        sentence = sentence +a;
        
        
        return sentence;
    }
}