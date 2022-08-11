public class Solution {
    public int MaxProfit(int[] prices) {
        
         
        int profit =0;
        int sum=0;
        for(int i =0,j=0;i<prices.Length && j<prices.Length;){
                if(prices[i]<prices[j]){
                    
                   
                       profit = (prices[j] - prices [i]);
                       sum = sum+profit;
                   
                    i=j;
                    j++;
                    
                    
                }
            else{
                i=j;
                j++;
            }
            
        
        
        
        }
        return sum;
        
        
    }
}