/*
    Time: O(logn)
    space:O(1)

    note: 1/result in the end to keep the result precise. 
    while loop: (2^2)^5 = 2^10
    2^7 = 2 * 2^6
*/
public class Powxn50 {
    public double MyPow(double x, int n) {
        if(x == 0 || x == 1){
            return x;
        }
        long exp = n;
        if(n < 0){
            exp = -1 * exp;
        }
        double result = 1;
        while(exp > 0){
            if(exp % 2 == 1){
                result *= x;
            }
            x *= x;
            exp /= 2;
        }
        
        if(n < 0){
            return 1 / result;
        }
        else{
            return result;
        }
    }
}