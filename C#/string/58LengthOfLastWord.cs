/*
    time: O(n)
    space:O(1)
*/
public class LengthOfLastWord58 {
    public int LengthOfLastWord(string s) {
        /*
            - use two pointer both starting from the last idx
                if(space) reduce both by 1
                found the first meaningful char: right = cur idx
                keep reducing left until reaching the next space 
            - return right - left
        */
        int right = s.Length - 1;
        int left = s.Length - 1;
        bool foundFirstChar = false;
        while(left >= 0){
            if(foundFirstChar && s[left] != ' '){
                left --;
            }
            else if(foundFirstChar && s[left] == ' '){
                return right - left;
            }

            if(!foundFirstChar && s[right] == ' '){
                right --;
                left --;
                continue;
            }

            foundFirstChar = true;
            
        }
        return right - left;
    }
}