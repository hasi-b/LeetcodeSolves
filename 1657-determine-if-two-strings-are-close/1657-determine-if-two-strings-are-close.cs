public class Solution {
    public bool CloseStrings(string word1, string word2) {
        
        
        
        int[] wor1 = new int[26];  
        int[] wor2 = new int[26];
        HashSet<int> hs = new HashSet<int>();
        HashSet<int> hst = new HashSet<int>();
        
        if(word1.Length!=word2.Length){
            return false;
        }
        else{
            
            
            for(int i=0;i<word1.Length;i++){
                
                int n = word1[i]%97;
                
                hs.Add(n);
                
                wor1[n]++;
                int m = word2[i]%97;
                
                hst.Add(m);
                wor2[m]++;
                
            }
            
           Array.Sort(wor1);
            Array.Sort(wor2);
            return wor1.SequenceEqual(wor2)&& hs.SetEquals(hst);
            
            
        }
        
    }
}