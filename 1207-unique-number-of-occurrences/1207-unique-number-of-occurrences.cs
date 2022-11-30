public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Hashtable ht = new Hashtable();
        
        for(int i=0;i<arr.Length;i++){
            
            if(ht.ContainsKey(arr[i])){
                
                int value = (int)ht[arr[i]];
                    ht[arr[i]] = value +1;
                
            }
            else{
                ht.Add(arr[i],1);
            }
        }
        
        HashSet<int> hset= new HashSet<int>();
        
        foreach(DictionaryEntry values in ht){
            
            hset.Add((int)values.Value);
        }
        
        
        if(ht.Count!=hset.Count){
            return false;
        }
        else{
            return true;
        }
        
        
        
    }
}