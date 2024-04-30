public class MedianofTwoSortedArrays {
    public static void main(String[] args) {
        int[] nums = {1, 3};
        int[] nums2 = {2};

        System.out.println(findMedianSortedArrays(nums, nums2));
    }
    public static double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] newArr = new int[nums1.length + nums2.length];
        int index = 0;
        int leftArr = 0;
        int rightArr = 0;

        while(leftArr < nums1.length && rightArr < nums2.length) {
            if (nums1[leftArr] < nums2[rightArr]) {
                newArr[index] = nums1[leftArr];
                index++;
                leftArr++;
            }
            else {
                newArr[index] = nums2[rightArr];
                index++;
                rightArr++;
            }
        }

        while(leftArr < nums1.length) {
            newArr[index] = nums1[leftArr];
            index++;
            leftArr++;
        }

        while(rightArr < nums2.length) {
            newArr[index] = nums2[rightArr];
            index++;
            rightArr++;
        }

        int arrLength = newArr.length;
        if (arrLength % 2 == 0) {
            double result = ( newArr[arrLength / 2 - 1] + newArr[arrLength / 2] ) / 2d;
            return result;
        } else {
            if (arrLength == 3) return newArr[1];
            else return newArr[arrLength / 2];
        }
    }
}
