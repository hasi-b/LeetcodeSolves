/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int l=1;
        int r=n;
        int mid = l+(r-l)/2;
        
        while(l<r){
            
            
            if(!IsBadVersion(mid)){
                
                l=mid+1;
                
                
            }
            else{
                r=mid;
                
            }
            
            mid=l+(r-l)/2;
        }
        
       if(l==r){
           return mid;
       }
        
        
        
        
        return mid+1;
       
        
    }
}