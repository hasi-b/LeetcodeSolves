public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        
        int n=mat.GetLength(0);
        int sum =0;
        
        int index = ((n+1)/2)-1;
       
        for(int i=0;i<n;i++){
            
            
            for(int j=0;j<n;j++){
                
                if(i==j){
                    
                    sum=sum+mat[i][j];
                }
                if(j==n-i-1){
                    
                    sum=sum+mat[i][j];
                }
                
            }
        }
        
        
        if(n%2!=0){
            sum=sum-mat[index][index];
        }
            
            return sum;
        
        
        
    }
}