public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Hashtable ht = new Hashtable();
        
        int [] ret = {0,0};
        
        for(int i=0;i<nums.Length;i++){
            
            
         
            
            if(ht.ContainsKey(target-nums[i]) ){
                
                ret[0] =i;
                ret[1]=(int)ht[target-nums[i]];
            }
            
            else{
                
                if(!ht.ContainsKey(nums[i]))
                
                ht.Add(nums[i],i);
            }
            
            
        }
        
        return ret;
        
        
        
        
    }
}