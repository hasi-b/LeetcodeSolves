public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result="";
        int count =0;
        string temp;
        
        if(word1.Length>word2.Length){
            count = word2.Length;
            temp = word1;
        }
        else{
            count = word1.Length;
            temp=word2;
        }
        for(int i=0;i<count;i++){
            result = result+word1[i];
            result = result  +word2[i];
        }
        for(int i=count;i<temp.Length;i++){
            
            result = result+temp[i];
        }
        
        return result;
    }
}