class Solution {
public:
    int removeElement(vector<int>& nums, int val) {
        int lastPos = -1;
        
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] == val and lastPos == -1) {
                lastPos = i;
            }
            else if (nums[i] != val and lastPos != -1) {
                nums[lastPos] = nums[i];
                lastPos++;
            }
        }
        
        // cout << "Returned " << lastPos << endl;
        
        if (lastPos == -1) return (int) nums.size();
        
        return lastPos;
    }
};

    /*
1 2 -1 1 2 -1 1 2 -1
1 2 1  2 1 2
    */