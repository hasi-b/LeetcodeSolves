public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        
        
        List<int> myList = new List<int>();
        Hashtable ht = new Hashtable();
        
        for(int i=0;i<nums.Length;i++){
            
            if(ht.ContainsKey(nums[i])){
                myList.Add(nums[i]);
            }
            else{
                ht.Add(nums[i],0);
            }
        }
        
        return myList;
    }
}