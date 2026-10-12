public class Solution {
    public int MaxSubArray(int[] nums) {
        //1. brute force
        // edge cases
        if(nums.Length == 0){
            return 0;
        }
        if(nums.Length == 1){
            return nums[0];
        }

        int sum = nums[0];
        // int substringStart = 0;
        // int substringEnd = 0;
        for(int i = 0; i < nums.Length; i++){
            int currentSum = 0;
            for(int j = i; j < nums.Length; j++){
                currentSum += nums[j];
                if(currentSum > sum){
                    sum = currentSum;
                }
            }

            
        }

        return sum;
        // 1 2 3
        /*
        1. 1    sum 1
        2. 1 2  sum 3
        3. 1 2 3 sum 6
        
        1. 2    sum 2
        2. 2 3  sum 5
        
        3. 3 sum 3
        */

    }
}