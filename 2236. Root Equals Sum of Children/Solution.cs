 public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


        /**
         * 檢查二元樹的根節點值是否等於其左右子節點值之和
         * @param root 二元樹的根節點
         * @return 如果滿足條件，回傳 true；否則回傳 false
         */
        public bool CheckTree(TreeNode root)
        {
            // 確認根節點是否存在
            if (root == null)
            {
                return false;
            }
            // 計算左子節點和右子節點的值之和
            int sum = 0;
            if (root.left != null)
            {
                sum += root.left.val;
            }
            if (root.right != null)
            {
                sum += root.right.val;
            }
            // 檢查根節點的值是否等於左右子節點值之和
            return root.val == sum;
        }
