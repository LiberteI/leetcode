public class SingleNum136 {
    public int SingleNumber(int[] nums) {
        /*
            use XOR ^ as XOR has following properities:
            1. a XOR a = 0
            2. a XOR 0 = a;

            as questions specifies all duplicates appears exactly twice, we must use this
        */
        int result = nums[0];
        for(int i = 1; i < nums.Length; i ++){
            result = result ^ nums[i];
        }

        return result;
    }
}