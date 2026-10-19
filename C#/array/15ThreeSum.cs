/*
    time: O(n^2)
    space: 
        sort: O(logn). 
        output: Fix one number → up to O(n) results. Do that for O(n) fixed numbers → O(n²) results.
*/

/*
while (left < right) {
    int j = 0; // Reset j to the beginning EVERY time

    while (j < nums.Length) {
        j++;
    }

    left++;
}
will make the inner while loop O(n)
*/

/*
    Reflection:
    1. sort the array makes life easier
    2. length - 2 reason
    3. to search for all possiblities, do not break the while loop
    4. make sure to update left and right to check dup
*/
public class ThreeSum15 {
    public IList<IList<int>> ThreeSum(int[] nums) {
        /*   
            - by considering different cases, we convert this question into 2 sum
        */
        List<IList<int>> lists = new List<IList<int>>();

        // fix one number and find the other 2 numbers to add up to this digit
        // start from item 1, find the other 2 in the rest of the list. for loop + 2 pointer

        // sort array to better check duplicate
        Array.Sort(nums);

        // length - 2 reason: loop should stop at the 3rd last element to guarantee there are enough elements
        for(int i = 0; i < nums.Length - 2; i ++){
            // Avoid repeating the same fixed number.
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int num = nums[i];

            int left = i + 1;
            int right = nums.Length - 1;

            while(left < right){
                int sum = num + nums[left] + nums[right];

                if(sum == 0){
                    lists.Add(new List<int>{num, nums[left], nums[right]});
                    // update both pointer becasue a different pair must update 2 used digits
                    left ++;
                    right --;

                    // skip the same elements
                    while(left < right && nums[left] == nums[left - 1]){
                        left ++;
                    }
                    while(left < right && nums[right] == nums[right + 1]){
                        right --;
                    }
                }
                
                if(sum < 0){ // left is too small
                    left ++;
                    continue;
                }
                if(sum > 0){ // right is too large
                    right --;
                    continue;
                }
            }

            
        }

        return lists;

    }
}
