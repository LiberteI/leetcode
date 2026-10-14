/*
    time: O(logn): 2 binary searches 
    space: O(1): no array being copied. only fixed number of vars appeared
*/

public class FindFirstLastPosOfElementInASortedArr34 {
    public int[] SearchRange(int[] nums, int target) {
        /*
            - use 2 binary searches to find the answers
        */

        int firstIdx = -1;
        int lastIdx = -1;

        int leftIdx = 0; 
        int rightIdx = nums.Length - 1;

        while(leftIdx <= rightIdx){
            int mid = (leftIdx + rightIdx) / 2;
            if(nums[mid] == target){
                firstIdx = mid;
                rightIdx = mid - 1; 
            }
            if(target < nums[mid]){
                rightIdx = mid - 1; 
            }
            else if(target > nums[mid]){
                leftIdx = mid + 1;
            }
        }

        leftIdx = 0; 
        rightIdx = nums.Length - 1;
        while(leftIdx <= rightIdx){
            int mid = (leftIdx + rightIdx) / 2;
            if(nums[mid] == target){
                lastIdx = mid;
                leftIdx = mid + 1; 
            }
            if(target < nums[mid]){
                rightIdx = mid - 1; 
            }
            else if(target > nums[mid]){
                leftIdx = mid + 1;
            }
        }
        return new[] {firstIdx, lastIdx};
    }
}

// public class FindFirstLastPosOfElementInASortedArr34 {
//     public int[] SearchRange(int[] nums, int target) {
//         /*
//             1. use binary search to find target.
//             2. keep searching left and right to find the first occurance or last occurance
//         */

//         int leftIdx = 0;
//         int rightIdx = nums.Length - 1;
//         int firstSeenIndex = -1;
//         while(leftIdx <= rightIdx){
//             int mid = (leftIdx + rightIdx) / 2;

//             if(nums[mid] == target){
//                 firstSeenIndex = mid;
//                 break;
//             }
//             if(target < nums[mid]){
//                 rightIdx = mid - 1; 
//             }
//             else if(target > nums[mid]){
//                 leftIdx = mid + 1;
//             }
//         }
//         // no target found
//         if(firstSeenIndex == -1){
//             return [-1, -1]; 
//         }
        
//         int firstLeftIdx = leftIdx;
//         int firstRightIdx = rightIdx;
//         int tempMid = firstSeenIndex;
//         // try find first occurance
//         while(tempMid >= 0 && tempMid <= nums.Length - 1 && nums[tempMid] == target){
//             firstRightIdx = tempMid - 1;

//             tempMid = (firstLeftIdx + firstRightIdx) / 2;
//         }
//         int firstIdx = tempMid + 1;

//         // reset temp vars
//         firstRightIdx = rightIdx;
//         tempMid = firstSeenIndex;

//         // try to find the second occurance
//         while(tempMid >= 0 && tempMid <= nums.Length - 1 && nums[tempMid] == target){
//             firstLeftIdx = tempMid + 1;
//             tempMid = (firstLeftIdx + firstRightIdx) / 2;
//         }
//         int secondFirstIdx = tempMid - 1;

//         int[] array = new int[2];
//         array[0] = firstIdx;
//         array[1] = secondFirstIdx;
//         return array;
//         /*
//             sample iteration
//             sample: [5,7,7,8,8,10] target = 8
//             mid          action        left, right
//             0                               0,5                 
//             2            7 < 8:             3,5  
//             4            8 = 8              first scanned -- record the current idx(4)

//             - try to scan left from here until find the first non-8 index. first occurance of 8 will be that index + 1
//             - try to scan right to find the last occurance by finding index - 1
            
//         left:4           8 = 8              3,4
//             3            8 = 8              3,3
//             3            8 = 8              3,2
//             2            7 < 8              found the first occurance: idx = 2+1 = 3
//         right:4          8 = 8              4,5
//             4            8 = 8              5,5
//             5            10> 8              found the second occurance: idx = 5-1 = 4
//         */
//     }
// }