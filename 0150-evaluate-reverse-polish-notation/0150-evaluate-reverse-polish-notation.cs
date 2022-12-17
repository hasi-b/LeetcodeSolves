public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> evaluate = new Stack<int>();
        
        for(int i=0;i<tokens.Length;i++){
            
            if(tokens[i]=="+"||tokens[i]=="-"||tokens[i]=="*"||tokens[i]=="/"){
                
                int a = (int)evaluate.Pop();
                int b = (int)evaluate.Pop();
                
                if(tokens[i]=="+"){

                evaluate.Push(b+a);
                }
                else if(tokens[i]=="-"){
                    evaluate.Push(b-a);
                }
                else if(tokens[i]=="*"){
                    evaluate.Push(b*a);
                    
                }
                else if(tokens[i]=="/"){
                    evaluate.Push(b/a);
                }
                
                
                
                
            }
            else{
                evaluate.Push(Convert.ToInt32(tokens[i]));
            }
            
            
        }
        return Convert.ToInt32(evaluate.Peek());
        
    }
}