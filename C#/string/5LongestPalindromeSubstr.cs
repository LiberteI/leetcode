/*
    time: O(n^2)
    space: O(1)

    note: 
        last element: Length - 1
        inside bound check: i < Length
            
*/

public class LongestPalindromeSubstr5 {
    public string LongestPalindrome(string s) {
        /*
            - use one for loop start at 0 
                nested two pointer: expand left and right to check if there is still palindrome
                check 2 conditions using local function: 
                    1. odd length of substring: left = i = right
                    2. even length of substring: left = i; right = i + 1;

            - checking palindrome:
                checking s[left] == s[right] then expand both sides
        */
        int longest = 0;
        int start = 0;

        for(int i = 0; i < s.Length; i++){
            // odd
            Expand(i, i); 
            // even
            Expand(i, i + 1);
        }

        return s.Substring(start, longest);

        void Expand(int left, int right){
            while(left >= 0 && right < s.Length && s[left] == s[right]){
                int length = right - left + 1;

                if(length > longest){
                    start = left;
                    longest = length;
                }

                left --;
                right ++;
            }
        }
    }
}