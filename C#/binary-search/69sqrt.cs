/*
    time: O(logn)
    space:O(1)

    reason for being able to discard half at a time:
    consider x = 8
    mid = 4 mid^2 = 16 > 8
    all nums' square after 4 are larger than 16
*/

// binary search
public class sqrt69 {
    public int MySqrt(int x) {
        /*
            - use binary search
            - set boundaries to 0 to x
                mid = ( 0 + x ) / 2
                if mid^2 > x set x = mid - 1
                else set 0 = 0 + 1

            8
            left    right     mid^2
            0       8         16
            0       3         9
            0       2         1
            1       2         1
            2       2         4
            3       2         9     
        */

        int left = 0;
        int right = x;

        while(left <= right){
            int mid = (left + right) / 2;
            long square = (long)mid * mid;
            if(square == x){
                return mid;
            }  
            if(square < x){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return left - 1;
    }
}