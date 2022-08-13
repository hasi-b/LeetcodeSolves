public class Solution {
    public string DefangIPaddr(string address) {
        
        
        String add="";
        
        
        for(int i=0;i<address.Length;i++){
            
            if(address[i]=='.'){
                add =add+ "[.]" ;
                
                
            }
            else{
                
                add =add+ address[i] ;
            }
            
        }
        return add;
        
        
    }
}