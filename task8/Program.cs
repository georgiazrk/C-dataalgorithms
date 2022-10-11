/* • In your own words, define BST balance factor.
• In your own words, describe the rules of 3 order B-tree.
• Insert the numbers 10 12 8 6 5 into an AVL tree.
o Draw the resulting tree before rebalancing
o Drawthetreeafterrebalancing
o What rotation was performed in rebalancing the tree? */

/* 

In your own words, define BST balance factor:

    The BST balance factor is the value given when you subtract the height of the right subtree of the BST from the height of the left subtree. If this value is less than -1 or greater than 1 then the BST is considered imbalanced. Otherwise it is considered balanced.

In your own words, describe the rules of 3 order B-tree:

    - Every node in the tree has a maximum of 3 children.
    - A node with 3 children must have 2 keys, as the children hold keys that belong within the bounds of the keys of the parent node.
    - The root has at least 2 children if it is not a leaf node.
    - Every node that is not a leaf node has at least 2 children.
    - All leaves are on the same level.

Insert the numbers 10, 12, 8, 6, 5 into an AVL Tree:

    Before rotation:

                    10          BF = 2-4 = -2
                   /  \
                  8   12        BF L = 0-3 = -3  BF R = 0
                 /
                6               BF = 0-2 = -2
               /
              5                 BF = 0

    After rotation:

                    10          BF = 2-3 = -1
                   /  \     
                  6   12        BF L = 2-2 = 0  BF R = 0
                 / \  
                5  8            BF L = 0  BF R = 0

    LL Imbalance was performed, a single right rotation.
*/