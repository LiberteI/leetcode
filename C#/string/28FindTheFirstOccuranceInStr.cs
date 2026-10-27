/*
    time: O(n^2)
    space:O(1)

    note: haystack.Length - needle.Length need to + 1
            return i condition need to be guarded

*/
public class FindTheFirstOccuranceInStr28 {
    public int StrStr(string haystack, string needle) {
        /*
            - use a single for loop. 
                if cur is needle[0], check if it fits
            leetc vs leeto
            e 

            a vs a
            0 = 0
            
            abc vs c
            c

        */

        for(int i = 0; i < haystack.Length - needle.Length + 1; i ++){
            if(haystack[i] == needle[0]){
                // start checking
                for(int j = 0; j < needle.Length; j ++){
                    if(haystack[i + j] != needle[j]){
                        break;
                    }

                    if(j == needle.Length - 1){
                        return i;
                    }
                    
                }
            }
        }

        return -1;
    }
}