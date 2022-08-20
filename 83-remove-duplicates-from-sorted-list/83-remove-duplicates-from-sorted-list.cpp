/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* deleteDuplicates(ListNode* head) {
        if (head == nullptr) {
            return head;
        }
        
        ListNode* curr = head;
        ListNode* last = head;
        
        while (curr->next != nullptr) {
            int prev = curr->val;
            curr = curr->next;
            if (curr->val != prev) {
                last->next = curr;
                last = curr;
            }
        }
        
        last->next = nullptr;
        
        return head;
    }
};