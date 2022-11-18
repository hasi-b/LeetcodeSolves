public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        
        int count=0;
        int sub=0;
        Hashtable ht = new Hashtable();
        for(int i=0;i<arr.Length;i++){
            
            ht.Add(arr[i],"n");
            
            
        }
        for(int i=1;i<arr[arr.Length-1];i++){
            
            if(!ht.ContainsKey(i)){
                count++;
                Console.WriteLine("COUNT "+count);
            }
            if(count==k){
                return i;
            }
            
            
        }
        
        if(count<k){
            sub = k-count;
            
        }
        
        return arr[arr.Length-1]+sub;
        
    }
}