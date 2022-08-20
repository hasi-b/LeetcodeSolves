class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        int lastPos = -1;
        
        for (int i = 0; i < nums.size(); i++) {
             if (nums[i] == 0 and lastPos == -1) {
                 lastPos = i;
             }
             else if (nums[i] != 0 and lastPos != -1) {
                 nums[lastPos++] = nums[i];
             }
        }
        
        for (int i = lastPos; i < nums.size(); i++) {
            nums[i] = 0;
        }
    }
};