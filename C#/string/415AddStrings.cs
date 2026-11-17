/*
    time: O(n)
    space: O(n)

    char to int: int num = '8' - '0';
    int to char: char ch = (char)(num + '0')
*/
public class AddStrings415 {
    public string AddStrings(string num1, string num2) {
        /*
            use 2 pointer
        */
        int curIdx1 = num1.Length - 1;
        int curIdx2 = num2.Length - 1;
        int carry = 0;
        StringBuilder reversedSB = new StringBuilder();
        while(curIdx1 >= 0 || curIdx2 >= 0){
            int sum = 0;
            if(curIdx1 >= 0 && curIdx2 >= 0){
                int curNum1 = num1[curIdx1] - '0';
                int curNum2 = num2[curIdx2] - '0';
                sum = curNum1 + curNum2 + carry;
            }
            else if(curIdx1 >= 0 && curIdx2 < 0){
                int curNum1 = num1[curIdx1] - '0';
                sum = curNum1 + carry;
            }
            else if(curIdx1 < 0 && curIdx2 >= 0){
                int curNum2 = num2[curIdx2] - '0';
                sum = curNum2 + carry;
            }
            
            int resultDigit = sum % 10;
            if(sum >= 10){
                carry = 1;
            }
            else{
                carry = 0;
            }
            reversedSB.Append((char)(resultDigit + '0'));

            curIdx1 --;
            curIdx2 --;
            
        }
        if(carry == 1){
            reversedSB.Append('1');
        }
        

        string reversedResult = reversedSB.ToString();
        StringBuilder sb = new StringBuilder();
        for(int i = reversedResult.Length - 1; i >= 0; i --){
            sb.Append(reversedResult[i]);
        }
        return sb.ToString();
    }
}