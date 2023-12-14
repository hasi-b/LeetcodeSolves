public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int[] row = new int[grid.Length];
        int[] col = new int [grid[0].Length];
        
       
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                if(grid[i][j]==1){
                    
                    row[i]++;
                    col[j]++;
                }
                if(grid[i][j]==0){
                    
                    row[i]--;
                    col[j]--;
                }
            }
        }
        
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
               grid[i][j]= row[i]+col[j];
            }
        }
        
        return grid;
        
    }
}