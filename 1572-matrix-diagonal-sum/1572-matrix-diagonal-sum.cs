public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        
        int n=mat.GetLength(0);
        int sum =0;
        
        int index = ((n+1)/2)-1;
       
        for(int i=0;i<n;i++){
            
            
            sum=sum+mat[i][i] + mat[i][n-i-1];
            
        }
        
        
        if(n%2!=0){
            sum=sum-mat[index][index];
        }
            
            return sum;
        
        
        
    }
}