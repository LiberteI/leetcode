/*
    all loops are O(1) but string builder is Logn
    time: O(logn)
    space:O(logn)

    note: 32 bits conversion need filling the rest of the zeros
*/
public class ReverseBinary190 {
    /*
        fill in zeros
    */
    public int ReverseBits(int n) {
        StringBuilder sb = new StringBuilder();
        while(n != 0){
            /*
                8
                0001 + the rest of 28 zeros
                1000
            */
            int remainder = n % 2;
            sb.Append(remainder);
            n = n / 2;
        }
        while(sb.Length != 32){
            sb.Append('0');
        }
        string binary = sb.ToString();

        int result = 0;
        int pow = 0;
        for(int i = binary.Length - 1; i >= 0; i--){
            if(binary[i] == '1'){
                result += (int)Math.Pow(2, pow) * (binary[i] - '0');  
            }
            pow ++;
        }

        return result;
    }
}