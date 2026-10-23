/*
    time: O(n)
    space: O(1)
    cast int to long for overflow
*/
public class SummaryRanges228 {
    public IList<string> SummaryRanges(int[] nums) {
        /*
            2 pointer
            [0,2,3,4,6,8,9,11]
            left    right     action
            0       1         nums[1] - nums[0] > 1; record left -> right - 1; left = right; right ++
            1       2         nums[2] - nums[1] = 1; right ++
            1       3          = 1; right ++
            1       4          > 1; record left -> right - 1; left = right; right ++
            4       5          > 1; record left -> right - 1; left = right; right ++
            5       6          = 1; right ++; 
            5       7          > 1; left = right; right ++
            7       8          right = nums.length. if left == right - 1, record last

        */
        List<string> list = new List<string>();

        // edge cases
        if(nums.Length == 0){
            return list;
        }

        // this is recorded by skipping the loop and the single Record call
        // if(nums.Length == 1){
        //     list.Add($"{nums[0]}");
        //     return list;
        // }

        int left = 0; 
        int right = 1;

        while(right < nums.Length){
            // this part can be safely done outside the loop 
            // if(right == nums.Length){
            //     Record(left, right, list, nums);
            //     break;
            // }
            // as else block only advance right. we can extract right out
            // if((long)nums[right] - nums[right - 1] > 1){
            //     Record(left, right, list, nums);
            //     left = right;
            //     right ++;
            // }
            // else{
            //     right ++;
            // }
            if((long)nums[right] - nums[right - 1] > 1){
                Record(left, right, list, nums);
                left = right;
            }
            right ++;
        }

        Record(left, right, list, nums);
        // if(right == nums.Length && left == nums.Length - 1){
        //     list.Add($"{nums[left]}");
        // }
        // else{
        //     list.Add($"{nums[left]}->{nums[right - 1]}");
        // }

        return list;
    }

    private void Record(int left, int right, List<string> list, int[] nums){
        if(right - 1 == left){
            list.Add($"{nums[left]}");
        }
        else{
            list.Add($"{nums[left]}->{nums[right - 1]}");
        }
    }
}