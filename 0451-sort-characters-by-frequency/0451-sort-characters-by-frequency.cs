public class Solution {
    public string FrequencySort(string s) {
        
        
         
        Dictionary<char,int> ht = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            if(ht.ContainsKey(s[i])){
                
                ht[s[i]] = (int)ht[s[i]] + 1;
            
            }
            else{
                ht.Add(s[i],1);
            }
        }
        
        
       var sdi = from c in ht orderby c.Value descending select c;
        var ss = new StringBuilder();

        foreach (var val in sdi)
        {
            ss.Append(val.Key,val.Value);
        }
        
        return ss.ToString();
        
        
    }
}