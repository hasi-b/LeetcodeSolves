public class Solution {
    public int BuyChoco(int[] prices, int money) {
        if(prices.Length<2){
            return money;
        }
        Array.Sort(prices);
        if(prices[0]+prices[1]<= money){
            return money-(prices[0]+prices[1]);
        }
        else{
            return money;
        }
        
    }
}