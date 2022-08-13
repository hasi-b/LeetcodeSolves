public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        
       int count =0;
        
        for(int i=0;i<operations.Length;i++){
            
            
            if(operations[i]=="X++" || operations[i]=="++X"){
                count++;
                
                
            }
            else{
                
                count --;
            }
            
            
        }
        return count;
        
    }
}