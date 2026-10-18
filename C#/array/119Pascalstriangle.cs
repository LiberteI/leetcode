/*
    time O(n^2)
    space: O(n)
*/
public class Pascalstriangle119 {
    public IList<int> GetRow(int rowIndex) {
        /*
            to make space complexity O(n): only store row[0] and derive the following using that row.
        */
        List<int> row = new List<int>();
        row.Add(1);
        for(int i = 1; i <= rowIndex; i ++){
            row.Add(1);
            for(int j = i - 1; j >= 1; j --){
                row[j] = row[j] + row[j - 1];
            }
        }

        return row;
        /*
            0: 1
            1: 1, 1
            2: 1, 1, 1 -> 1, 1+1, 1
                2 = 1 + 1
            3: 1, 2, 1, 1 -> 1, 2, 3, 1 -> 1, 3, 3, 1
                3 = 2 + 1
                2 -> 2 + 1 = 3

            

            4: 1, 3, 3, 1, 1 -> 1, 3, 3, 4, 1 -> 1, 4, 6, 4, 1
                4 = 3 + 1
                3 -> 3 + 3 = 6
                3 -> 3 + 1 = 4
        */



        

    }
    
}
/*
    time: O(n^2), where n = numRows; 1 + 2 + ... + n elements are generated.
    space: O(n^2) for the returned triangle; O(1) auxiliary space excluding output.

    note: list cannot use index to access before it is populated
*/
