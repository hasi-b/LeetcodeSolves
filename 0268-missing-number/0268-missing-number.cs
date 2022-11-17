public class Solution {
    public int MissingNumber(int[] nums) {
        
        
        Hashtable ht = new Hashtable();
        
        
        for(int i=0;i<nums.Length;i++){

        
            ht.Add(nums[i],"s");
            
        
        }
        
        
        for(int i=0;i<nums.Length+1;i++){
            
            if(!ht.ContainsKey(i)){
                
                return i;
            }
        }
        
        return -1;
    }
}