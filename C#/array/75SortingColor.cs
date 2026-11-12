/*
    time: O(n)
    space: O(1)
    note: when there is a limit num of circumstances, consider counting
*/
public class SortingColor75 {
    public void SortColors(int[] nums) {
        int zeros = 0;
        int ones = 0; 
        int twos = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                zeros ++;
            }
            if(nums[i] == 1){
                ones ++;
            }
            if(nums[i] == 2){
                twos ++;
            }
            
        }

        int cur = 0;
        for(int i = 0; i < zeros; i++){
            nums[cur] = 0;
            cur ++;
        }
        for(int i = 0; i < ones; i++){
            nums[cur] = 1;
            cur ++;
        }
        for(int i = 0; i < twos; i++){
            nums[cur] = 2;
            cur ++;
        }
    }
}