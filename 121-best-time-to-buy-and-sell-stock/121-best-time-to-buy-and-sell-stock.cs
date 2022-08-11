public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit =0;
        for(int i =0,j=0;i<prices.Length && j<prices.Length;){
                if(prices[i]<prices[j]){
                    
                   if(prices[j]-prices[i]>profit) {
                       
                       profit = prices[j] - prices [i];
                   }
                    
                    j++;
                    
                    
                }
            else{
                i=j;
                j++;
            }
            
        
        
        
        }
        return profit;
        
    }
}