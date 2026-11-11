/*
    time: O(n)
    space:O(1)

    note: 
    pass        third = second;
                second = first;
                first = num;

    use long as initial number
*/
public class ThirdMaxNum414 {
    public int ThirdMax(int[] nums) {
        long first = long.MinValue;
        long second = long.MinValue;
        long third = long.MinValue;

        foreach(int num in nums){
            if((long)num > (long)first){
                third = second;
                second = first;
                first = num;
            }
            else if((long)num > (long)second && (long)num < (long)first){
                third = second;
                second = num;
            }
            else if((long)num > (long)third && (long)num < (long)second) {
                third = num;
            }
        }
        if(third == long.MinValue || third == second || third == first){
            return (int)first;
        }
        return (int)third;
    }
}