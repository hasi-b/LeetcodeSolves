public class Solution {
    public int CalPoints(string[] operations) {
        
        Stack myStack = new Stack();
        int D=0;
        int p=0;
        int sum=0;
        for(int i=0;i<operations.Length;i++){
            
            if(myStack.Count>0){
                
                if(operations[i]=="C"){
                    
                    myStack.Pop();
                    
                }
                else if(operations[i]=="D"){
                    
                    myStack.Push((int)myStack.Peek()*2);
                    
                }
                else if(operations[i]=="+"){
                    D=(int)myStack.Pop();
                    p = D+(int)myStack.Peek();
                    myStack.Push(D);
                    myStack.Push(p);
                }
                else{
                    myStack.Push(int.Parse(operations[i]));
                }
                
            }
            else{
                
                myStack.Push(int.Parse(operations[i]));
            }
            
            
            
            
            
        }
        
        while(myStack.Count>0){
            sum=sum+(int)myStack.Pop();
            
        }
        return sum;
    }
}