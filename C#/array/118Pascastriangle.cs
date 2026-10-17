/*
    time: O(n^2), where n = numRows; 1 + 2 + ... + n elements are generated.
    space: O(n^2) for the returned triangle; O(1) auxiliary space excluding output.

    note: list cannot use index to access before it is populated
*/
public class Pascastriangle118 {
    public IList<IList<int>> Generate(int numRows) {
        /*
            row = 5
            e0 = 1
            e1 = le0 + le1
            e2 = le1 + le2
    `       e3 = le2 + le3
            e4 = 1
        */
        IList<IList<int>> triangle = new List<IList<int>>(numRows);
        for(int i = 0; i < numRows; i++){
            // init list
            triangle.Add(new List<int>(i + 1));

            for(int j = 0; j <= i; j ++){
                if(j == 0 || j == i){
                    triangle[i].Add(1);
                    continue;
                }
                triangle[i].Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);

            }
        }

        return triangle;
        
    }
}
