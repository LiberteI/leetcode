/*
    Time: O(n^2)
    Space:O(n)

    note: properly handle equal situation
*/
public class LargestMergeOf2Str1754 {
    public string LargestMerge(string word1, string word2) {
        /*
            - use 2 pointer
            - initialise word1 pointer and word2 pointer at first char
                compare both chars using string.CompareOrdinal(a, b)
                if < 0, add b to string
                if > 0, add a to string
        */
        int word1idx = 0;
        int word2idx = 0;
        string result = "";
        while(word1idx < word1.Length || word2idx < word2.Length){
            if(word1idx == word1.Length){
                result += word2[word2idx];
                word2idx ++;
                continue;
            }
            if(word2idx == word2.Length){
                result += word1[word1idx];
                word1idx ++;
                continue;
            }

            if(word1[word1idx] < word2[word2idx]){
                result += word2[word2idx];
                word2idx ++;
            }
            else if(word1[word1idx] > word2[word2idx]){
                result += word1[word1idx];
                word1idx ++;
            }
            else{// word1[word1idx] == word2[word2idx]
                // find the next chars that they both differ
                int nextDiff1 = word1idx;
                int nextDiff2 = word2idx;
                while(nextDiff1 < word1.Length && nextDiff2 < word2.Length &&
                    word1[nextDiff1] == word2[nextDiff2]
                )
                {
                    nextDiff1 ++;
                    nextDiff2 ++;
                }
                // getting next diff pairs will yield 4 conditions:
                /*
                    1. both reach the end: the rest suffix is the same. add char from either
                    2. neither reaches the end: add the next char from word with bigger nextdiff char
                    3. only word1 reaches the end: it means word1 is a prefix of word2. add next char from word2
                    4. only word2 reaches the end: the reverse condition of no.3
                */
                if(nextDiff1 == word1.Length && nextDiff2 == word2.Length){
                    result += word1[word1idx];
                    word1idx ++;
                }
                else if(nextDiff1 != word1.Length && nextDiff2 != word2.Length){
                    if(word1[nextDiff1] < word2[nextDiff2]){
                        result += word2[word2idx];
                        word2idx ++;
                    }
                    else{
                        result += word1[word1idx];
                        word1idx ++;
                    }
                }
                else if(nextDiff1 != word1.Length && nextDiff2 == word2.Length){
                    
                    result += word1[word1idx];
                    word1idx ++;
                }
                else{
                    result += word2[word2idx];
                    word2idx ++;
                }
            }
        }
        /*
            1       2     action
            0 c     0 b   c > b; "c"
            1 a     0 b   a < b; "cb"
            1 a     1 c   a < c; "cbc"
            1 a     2 a   a = a; next different chars are at 2, null respectively: add a in word1   
                                while loop 1: find next different char in word1
                                while loop 2: find next dff       char in word2
                                if(diff == wordLengh) add the other
                                if this diff - curIdx is smaller, add the other

            1       2       action
            a       a       a = a; next diff chars are at 1 and 1    
        */

        return result;
    }
}