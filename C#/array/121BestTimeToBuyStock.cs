/*
    time: O(n-1) = O(n)
    space:O(1)
*/
public class BestTimeToBuyStock121 {
    public int MaxProfit(int[] prices) {
        /*
            use two pointer so that we naturally check future vs now
        */
        // edge case
        if(prices.Length <= 1){
            return 0;
        }

        int left = 0;
        int right = 1;
        int max = prices[right] - prices[left];
        while(right < prices.Length){
            // if max is negative, set current left to current right because right is the next small value to buy stock
            if(prices[right] - prices[left] < 0){
                left = right;
                right ++;
                continue;
            }
            
            max = Math.Max(max, (prices[right] - prices[left]));
            right ++;
            // if max is positive, advance right only to try to find a better deal
        }

        if(max <= 0){
            return 0;
        }
        else{
            return max;
        }
    }

    /*
        [7,1,5,3,6,4]
        left    right    max      action   
         0       1        -6        advance left and right becasue left is too large    
         1       2        4         advance right because we need to find if there is better deal
         1       3        2         advance right
         1       4        5         advance right   
         1       5        4         finish
         ...         
    */

    /*
        consider: [7, 2, 5, 1, 6]
        when right reaches 1, prices[left] > price[right], so left gets updated
        so nothing is ignored by not reseting right
    */
}