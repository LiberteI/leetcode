

/*
    time: O(n^2)
    space:O(n)

    note: else block should be left ++ length --
            setting left to right will omit cases like 1R1T7 

    optimization idea:
        A sliding window with a HashSet<char> will have O(n) time 
*/
public class LongestSubstrWithoutRepeatedChar3 {
    public int LengthOfLongestSubstring(string s) {
        /*
            - use two pointer
                1. init both at the start
                2. if next is different than past, chars advance right
                   else: left ++
                3. check dup by 
                    1. get the substring from left to right. .Substring(left, right - left)
                    2. check substring.Contains(nextChar)
        */

        int left = 0;
        int right = 0;
        int longest = 0;
        int curLength = 0;
        /*
            1R1T7  
            0 1 1
            0 2 1R
            0 3 
            1 3 R1T
            1 4 R1T7       
        */
        while(right < s.Length){
            string sub = s.Substring(left, right - left);

            if(!sub.Contains(s[right])){
                curLength ++;
                longest = Math.Max(longest, curLength);
                right ++;
            }
            else{
                left ++;
                curLength --;
            }
            
        }

        return longest;
    }
}