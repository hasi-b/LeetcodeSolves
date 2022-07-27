public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        int flag =0;
        
        Hashtable c = new Hashtable();
        
        for(int i =0;i<jewels.Length;i++){
            
            
            if(c.ContainsKey(jewels[i])){
                continue;
            }
            else{
                c.Add(jewels[i],null);
            }
        }
        
        for(int i =0;i<stones.Length;i++){
            
            if(c.ContainsKey(stones[i])){
                flag++;
            }
            
        }
        
        return flag;
        
    }
}