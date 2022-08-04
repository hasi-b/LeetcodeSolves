public class Solution {
    public int MaxArea(int[] height) {
        
        
        int ar=0;
        int area =0;
        int l=0;
        int r=height.Length-1;
        
        
        
        while(l<r){
            
            
            if(height[l]<height[r]){
                
                ar = height[l]*(r-l);
                l++;
                
            }
            else{
                
                
                ar = height[r]*(r-l);
                r--;
            }
            
            if(ar>area){
                area = ar;
            }
            
        }
        
        return area;
    }
}