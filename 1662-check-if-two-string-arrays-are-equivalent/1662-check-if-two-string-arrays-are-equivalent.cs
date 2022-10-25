public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        
        String w1="";
        String w2="";
        
        for(int i=0;i<word1.Length;i++){
            w1 = w1+word1[i];
            Console.WriteLine(w1);
        }
        for(int i=0;i<word2.Length;i++){
             w2 = w2+word2[i];
            
        }
        if(w1==w2){
            return true;
        }
        else{return false;}
    }
}