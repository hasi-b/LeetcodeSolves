public class Solution {
    public string Interpret(string command) {
        
        string s="";
        for(int i=0;i<command.Length;i++){
            
            
            if(command[i]=='G'){
            
                s=s+"G";
                
            }
            else if(command[i]=='(' && command[i+1]==')' && i+1<command.Length){

            s=s+'o';
                i++;
            }
            else if(command[i]=='(' && command[i+1]=='a' && command[i+2]=='l' && command[i+3]==')' && i+3<command.Length){
                s=s+"al";
                i=i+3;
            }
            
        }
        return s;
        
    }
}