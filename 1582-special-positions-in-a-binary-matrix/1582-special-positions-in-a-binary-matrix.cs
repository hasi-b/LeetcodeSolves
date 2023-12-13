public class Solution {
    public int NumSpecial(int[][] mat) {
        int count=0;
        int[] row = new int[mat.Length];
        int[] col = new int[mat[0].Length];
        
        for(int i=0;i<mat.GetLength(0);i++){
            for(int j=0;j<mat[i].GetLength(0);j++){
                if(mat[i][j]==1){
                    
                    row[i]++;
                    col[j]++;
                    
                }
                          
            }
        }
         for(int i=0;i<mat.GetLength(0);i++){
            for(int j=0;j<mat[i].GetLength(0);j++){
                if(mat[i][j]==1 && row[i]==1 && col[j]==1){
                    
                    count++;
                    
                }
                          
            }
        }
        
        
        
        return count;
    }
}