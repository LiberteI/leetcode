public class Solution {
    public int MaxSubArray(int[] nums) {
        // optimized algorithm: Kadane’s algorithm
        // create 2 variables to compare starting fresh and continuing: is starting at this number better than adding it to prev subarray??

        // edge case: 
        if(nums.Length == 0){
            return 0;
        }
        // currentSum: What is the largest subarray sum ending exactly at this index?
        // sum: What is the largest subarray sum found anywhere so far?
        int sum = nums[0];
        int currentSum = nums[0];

        for(int i = 1; i < nums.Length; i++){
            // decide if to start fresh or add to sum

            // prev sum is negative
            if(currentSum < 0){
                currentSum = nums[i];
            }
            else{ // num[i] <= nums[i] + currentSum
                currentSum += nums[i];                
            }

            // Update the best overall sum if currentSum is larger
            if(currentSum > sum){
                sum = currentSum;
            }
        }

        return sum;

    }
}
// 
// public class Solution {
//     public int MaxSubArray(int[] nums) {
//         //1. brute force
//         // edge cases
//         if(nums.Length == 0){
//             return 0;
//         }
//         if(nums.Length == 1){
//             return nums[0];
//         }

//         int sum = nums[0];
//         // int substringStart = 0;
//         // int substringEnd = 0;
//         for(int i = 0; i < nums.Length; i++){
//             int currentSum = 0;
//             for(int j = i; j < nums.Length; j++){
//                 currentSum += nums[j];
//                 if(currentSum > sum){
//                     sum = currentSum;
//                 }
//             }

            
//         }

//         return sum;
//         // 1 2 3
//         /*
//         1. 1    sum 1
//         2. 1 2  sum 3
//         3. 1 2 3 sum 6
        
//         1. 2    sum 2
//         2. 2 3  sum 5
        
//         3. 3 sum 3
//         */

//     }
// }