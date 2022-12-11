public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {


        int j=m-1;
        int k=nums1.Length-1;
        int i=n-1;

        
        for(;i>=0&&j>=0;){

                if(nums1[j]<nums2[i]){

                    nums1[k]=nums2[i];
                    i--;
                   
                }
                else{
                    nums1[k]=nums1[j];
                   
                    j--;
                }
                k--;


        }
        while(i>=0){
            nums1[k] = nums2[i];
            i--;
            k--;

        }




        
    }
}