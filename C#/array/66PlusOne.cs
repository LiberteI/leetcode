public class PlusOne {
    public int[] Solution(int[] digits) {
        /*
            1. add one to the last digit
            2. sweep across the array from the last digit, if it is 10, add one to the num prior to it.
            3. resize: if all digits are 9, handle it by shifting all nums to the right and then add 1 to the front
            4. as c#'s Array.resize(ref nums, newSize) will populate the num with 0. the first num will be 10. just reset it to 1
        */
        int lastNumIdx = digits.Length - 1;
        digits[lastNumIdx] ++;
        if(digits[lastNumIdx] != 10){
            return digits;
        }

        for(int i = lastNumIdx; i >= 0; i --){
            // if array is all 9's
            if(i == 0 && digits[i] == 10){
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
                return digits;
            }

            if(digits[i] == 10){
                digits[i] = 0;
                digits[i - 1] ++;
            }
        }

        return digits;
    }
}