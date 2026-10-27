using System.Text.RegularExpressions;
public class ValidPalidrome125 {
    public bool IsPalindrome(string s) {
        /*
            - remove all none aphabetical chars: Regex.Replace(text, "[^a-zA-Z]", "");
                using System.Text.RegularExpressions;
            - use a single while loop to determine

            ampma
            a   a
            m   m
            p   p

        */

        string cleanedS = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLowerInvariant();
        int left = 0;
        int right = cleanedS.Length - 1;
        while(left <= right){
            if(cleanedS[left] != cleanedS[right]){
                return false;
            }
            left ++;
            right --;
        }

        return true;
    }
}