# C# Interview Coding Arena

My collection of C# LeetCode solutions for coding interview preparation. Each solution includes notes on the approach, and many include complexity analysis, worked examples, reflections, or earlier attempts.

## Patterns to Review

### Two pointers

Move pointers based on which choice can still improve the answer. For 3Sum, sorting also makes duplicate handling easier.

- [11. Container With Most Water](C%23/array/11ContainerWMostWater.cs)
- [15. 3Sum](C%23/array/15ThreeSum.cs)
- [16. 3Sum Closest](C%23/array/16ThreeSumClosest.cs)
- [88. Merge Sorted Array](C%23/array/88MergeSortedArray.cs)
- [121. Best Time to Buy and Sell Stock](C%23/array/121BestTimeToBuyStock.cs)

### Binary search

Narrow the search interval. Continue toward a boundary after finding a match when the problem asks for the first or last occurrence.

- [34. Find First and Last Position of Element in Sorted Array](C%23/array/34FindFirstLastPosOfElementInASortedArr.cs)
- [35. Search Insert Position](C%23/array/35SearchInsertPosition.cs)

### Kadane’s algorithm

Track the best sum ending at the current index and the best sum seen overall. Start fresh when the previous running sum is negative.

- [53. Maximum Subarray](C%23/algorithms/53MaximumSubarray.cs) (interviewed with Magnet Forensics.)

### Boyer–Moore voting

Cancel different values against one another. The solution relies on the problem’s guarantee that a majority element exists.

- [169. Majority Element](C%23/array/169majorityNum.cs)

### Bit manipulation

Use `a ^ a = 0` and `a ^ 0 = a` to isolate the single value when every other value appears exactly twice.

- [136. Single Number](C%23/array/136SingleNum.cs)

### Recursion and tree traversal

Build a balanced BST from midpoint values. The notes explore preorder, inorder, and postorder traversal; the active print helper uses preorder.

- [108. Convert Sorted Array to Binary Search Tree](C%23/array/108ConvertSortedArraytoBSTree.cs)

### Dynamic programming

Derive Pascal’s Triangle from earlier values. Updating right to left allows the single-row version to preserve values it still needs.

- [118. Pascal’s Triangle](C%23/array/118Pascastriangle.cs)
- [119. Pascal’s Triangle II](C%23/array/119Pascalstriangle.cs)

### Carry propagation

Process digits from the end and handle overflow into a new leading digit.

- [66. Plus One](C%23/array/66PlusOne.cs)
