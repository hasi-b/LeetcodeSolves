/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        
        
        List<int> tree = new List<int>();
        
        
        
        
        void PreOrder(TreeNode root){
            
            
            if(root==null){
                return ;
            }
            else{
                
                tree.Add(root.val);
                PreOrder(root.left);
                PreOrder(root.right);
                
            }
            
            
        }
        PreOrder(root);
        return tree;
        
        
    }
}