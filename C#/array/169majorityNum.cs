/*
    Boyer-Moore voting
    time O(n)
    space O(1)
*/
public class majorityNum169 {
    public int MajorityElement(int[] nums) {
        /*
            Boyer–Moore voting
            - take 1st as candidate
            - if later element equals to it, count ++, otherwise, count --;
            - count = 0, use the next element as candidate
            - as if one num has 2/n count, it will survive at last
        */
        
        int candidate = nums[0];
        int count = 0;

        foreach(int num in nums){
            if(count == 0){
                candidate = num;
            }
            if(num == candidate){
                count ++;
            }
            else{
                count --;
            }
            
            
        }

        return candidate;
    }

// /*
//     time: O(n)
//     space: O(n)
// */  
//     Dictionary<int, int> dic = new Dictionary<int, int>();

//     foreach(int num in nums){
//         if(!dic.ContainsKey(num)){
//             dic[num] = 0;
//         }

//         dic[num] ++;

//         if(dic[num] > nums.Length/2){
//             return num;
//         }
//     }

//     return 0;
// } 
// /*
//     time: O(nlogn) for sorting call
//     space:O(nlogn) for sorting call
// */
//         /*
//             O(n) solution:
//             1. sort the array (nlogn)
//             2. when there are consecutive element in the array, record and then see if it appears more than n/2 times
//         */

//         // edge case: 
//         if(nums.Length == 1){
//             return nums[0];
//         }
//         Array.Sort(nums);
//         int maxOccurance = 1;
//         for(int i = 1; i < nums.Length; i++){
            
//             if(nums[i] == nums[i - 1]){
//                 maxOccurance ++;
//             }
//             else{
//                 maxOccurance = 1;
//             }

//             if(maxOccurance > nums.Length / 2){
//                 return nums[i - 1];
//             }
//         }

//         return 0;
//     }
}