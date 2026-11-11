/*
    time: O(n)
    space:O(1)
*/
public class ExcelSheetTitleNumber171 {
    public int TitleToNumber(string columnTitle) {
        /*
            start from the last char.
            Length      range
            1           1-26
            AA          1 + 26
            AB          2 + 26
            BA          1 + 26 * 2
            AAA         1 + 26 * 1 + 26^2 * 1

            char a = 'A'
            char b = 'B'
            int pos = b - a + 1;
        */

        int result = 0;
        int j = 0;
        for(int i = columnTitle.Length - 1; i >= 0; i --){
            result += (int)Math.Pow(26, j) * (int)(columnTitle[i] - 'A' + 1);
            j ++;
        }
        return result; 

    }
}