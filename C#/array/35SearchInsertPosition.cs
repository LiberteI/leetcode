/*
    time complexity: O(logn): not all element is swept. the whole array is swept in halves and the rest is ignored
    space complexity: O(1): there is no array that takes more than constant element.

*/

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
        // break when left > right
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

        // example derivation
        /*
            Example: insert 5 into [1, 3, 6, 8].
            Step	Middle value	Action
            left = 0, right = 3	3 is smaller than 5	Set left = 2
            left = 2, right = 3	6 is larger than 5	Set right = 1

            left > right so loop stops
            so return left
        */
    }
}