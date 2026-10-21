/*
    time: O(n^2)
    space:O(logn) from sorting array.

    some reflections:
    1. int currentClosest = nums[0] + nums[1] + nums[2]; as output is a sum, this should be initialised as a sum rather than a single number
    2. Math.Abs(sum - target) < Math.Abs(currentClosest - target)
    3. dup does not matter in this question
*/
public class ThreeSumClosest16 {
    public int ThreeSumClosest(int[] nums, int target) {
        /*
            - idea: try to convert it to 3 unique nums adding up to 0
                    now it should add up to target
            - use a for loop and nested 2 pointer
            - 

            consider this example: [-1,2,1,-4] -> [-4,-1,1,2] target = 1;
            cur left right      sum     action
             -4   -1   2        -3      -3 < 1 advance left, record -3
             -4    1   2        -1      -1 < 1. left = right advance cur, record -1
             -1    1   2        2       2 > 1   for loop ends. output 2
        */
        // sort array
        Array.Sort(nums);
        // init closest num tracker
        int currentClosest = nums[0] + nums[1] + nums[2];
        int left = 0;
        int right = nums.Length - 1;
        
        // length - 2 to prevent out of bound error
        for(int i = 0; i < nums.Length - 2; i ++){
            left = i + 1;
            right = nums.Length - 1;
            while(left < right){

                int sum = nums[i] + nums[left] + nums[right];

                if(Math.Abs(sum - target) < Math.Abs(currentClosest - target)){
                    currentClosest = sum;
                }

                if(sum < target){
                    left ++;
                }
                else{
                    right --;
                }
                
            }
        }

        return currentClosest;
    }
}