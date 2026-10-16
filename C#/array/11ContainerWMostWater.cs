/*
    time: O(n)
    space: O(1)
*/

// *** Two Pointer ***
public class ContainerWithMostWater11 {
    public int MaxArea(int[] height) {
        /*
            example: 49 = 7 * (8 - 1)
            volumn = (index1 - index2) * min(height[idx1], height[idx2])

            how to find the max volumn:
            - use 2 pointers. 0 and Length - 1
            - iterate by moving the one with shorter height. remember the maximum so that when distance shrinks, we know the past max value.

            archive: O(n^2) solution
            1. remember the current maximum
            2. use 2 for loops to iterate through all possibilities.
        */
        int leftIdx = 0;
        int rightIdx = height.Length - 1;
        int sum = -1;
        while(leftIdx < rightIdx){
            int distance = rightIdx - leftIdx;
            int smallerHeight = Math.Min(height[leftIdx], height[rightIdx]);
            int volumn = smallerHeight * distance;

            sum = Math.Max(sum, volumn);
            if(height[leftIdx] > height[rightIdx]){
                rightIdx -= 1;
            }
            else{
                leftIdx += 1;
            }
        }
        return sum;
        // int sum = -1;

        // for(int i = 0; i < height.Length; i++){
        //     for(int j = i + 1; j < height.Length; j ++){
        //         int smallerHeight = Math.Min(height[i], height[j]);
        //         int difference = j - i;

        //         int volumn = smallerHeight * difference;

        //         sum = Math.Max(sum, volumn);
        //     }
        // }

        // return sum;
    }
}