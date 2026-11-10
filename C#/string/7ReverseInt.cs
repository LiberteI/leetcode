/*
    time: O(n^2). string in C# is immutable.
    using System.Text;

    var builder = new StringBuilder(5); // Room for 5 characters
    builder.Append('a');               // Length 1, capacity 5
    builder.Append('b');               // Length 2, capacity 5
    builder.Append('c');               // Length 3, capacity 5

    string result = builder.ToString(); // "abc"
    space:O(n)
*/
public class ReverseInt7 {
    public int Reverse(int x) {
        /*
            cast x into string and operate on the string and then cast string back into int
            int = int.TryParse(intput, out int output)
            string = num.ToString();
        */
        string num = x.ToString();
        string target = "";
        
        for(int i = num.Length - 1; i >= 0; i --){
            // handle consecutive 0's
            if(num[i] == '-'){
                break;
            }
            target += num[i];
            
        }
        
        int.TryParse(target, out int targetNum);
        if(num[0] == '-'){
            targetNum = - targetNum;   
        }
        if(targetNum > Math.Pow(2, 31) - 1 || targetNum < - Math.Pow(2, 31)){
            return 0;
        }
        return targetNum;
    }
}