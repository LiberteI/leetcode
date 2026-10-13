public class SearchInsertPosition35 {
    public int SearchInsertPosition(int[] nums, int target) {
        /*
            - logn usually indicate binary search
            - use binary search: always check the middle element. 2n + 1 or 2n number of elements: check no.n element
        
        */

        int leftIdx = 0;
        int rightIdx = nums.Length - 1;
        if(rightIdx < 0){
            return 0;
        }

        while(leftIdx <= rightIdx){
            int mid = (leftIdx + rightIdx) / 2;

            if(nums[mid] == target){
                return mid;
            }
            if(nums[mid] > target){
                // nums at mid and after mid is too large for target
                // shift rightIdx to the first element of mid
                rightIdx = mid - 1;
            }
            else if (nums[mid] < target){ // nums[mid] < target
                // nums at mid and before mid is too small for target
                leftIdx = mid + 1;
            }
        }
        
        return leftIdx;
        /*
            left: 0 1; 0 1
            right: 3 3;3 3
            output: 2
    
        */
    }
}