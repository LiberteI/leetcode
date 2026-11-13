/*
    time: O(logn)
        while: binary so logn; ToString(): logn; for(): looping through digits derived from the while loop so logn
    space:O(logn) String Builder and ToString. This question does not need us to store binary result. this could be optimised to O(1) by simply adding result
    If this function is called many times, how would you optimize it?
    int is 32 bits. we store the pattern mapping for one byte and check the 4 byte
*/
using System.Text;
public class NumOfOneBits191 {
    public int HammingWeight(int n) {
        StringBuilder binarySB = new StringBuilder();
        /*
            n       remainder
            11      0
            5       1
            2       1
            1       0
            0       1
        */
        while(n != 0){
            int remainder = n % 2;
            n = n / 2;
            binarySB.Append(remainder);
        }
        string binary = binarySB.ToString();
        int result = 0;
        for(int i = 0; i < binary.Length; i ++){
            if(binary[i] == '1'){
                result ++;
            }
        }
        return result;
    }
}