/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        
        
        int l=1,r=n;
        int k=(l+r)/2;
        
        
        if(guess(n)==0){
            return n;
        }
        
        while(true){
            
            if(guess(k)==0){
                return k;
            }
            
            else if(guess(k)==1){
                l=k+1;
                
                
            }
            else if(guess(k)==-1){
                r=k-1;
                  
            }
            
            k=l+(r-l)/2;
            
        }        return k;
    }
}