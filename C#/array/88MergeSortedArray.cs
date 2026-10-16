/*
    time: O(m+n)
    space: O(m + n): an array of m + n length is copied

    lesson: handle idx out of bound before accessing an array
*/

// *** TWO POINTER ***
public class MergeSortedArray88 {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        /*
            - use bigger to track larger value in either array.
            - if current value is smaller than bigger, freeze this array and process the other array.
        */

        int[] nums3 = new int[m + n];

        int nums1Idx = 0;
        int nums2Idx = 0;

        for(int i = 0; i < m + n; i ++){
            // handle exhaustion
            if(nums1Idx >= m){
                nums3[i] = nums2[nums2Idx];
                nums2Idx ++;
                continue;
            }
            if(nums2Idx >= n){
                nums3[i] = nums1[nums1Idx];
                nums1Idx ++;
                continue;
            }



            // before exhaustion
            int bigger = Math.Max(nums1[nums1Idx], nums2[nums2Idx]);

            if(nums1[nums1Idx] == bigger){
                nums3[i] = nums2[nums2Idx];
                nums2Idx ++;
            }
            else{ // nums2[nums2Idx] is bigger
                nums3[i] = nums1[nums1Idx];
                nums1Idx ++;
            }
        }

        for(int i = 0; i < nums3.Length; i++){
            nums1[i] = nums3[i];
        }
        /*
            bigger,            indices         action   array
            num1:2              0, 0            0, 0;   1
            num
        */

        /*
            Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            sample iteration:
            nums1       nums2          action
            1           2              bigger = 2. insert 1
            2           2              bigger = 2. insert 2 in nums1
            3           2              bigger = 3. insert 2 in nums2
            0(terminate)5              bigger = 5. insert 5
            0           6              bigger = 6. insert 6          
        */
    }
}