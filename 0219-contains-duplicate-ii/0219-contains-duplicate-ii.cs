public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        
     Hashtable ht = new Hashtable();
        
        for(int i=0;i<nums.Length;i++){
            
            if(ht.ContainsKey(nums[i])){
                
                int n = (int)ht[nums[i]];
                if(Math.Abs(i-n)<=k){
                    return true;
                }
                else{
                    
                    ht[nums[i]] =i;
                }
                
            }
            else{
                ht.Add(nums[i],i);
            }
        }
        
        
        return false;
    }
}