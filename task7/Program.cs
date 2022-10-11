using static System.Console;

class Program
{
    static void Main()
    {
        Task7();
    }
    static void Task7()
    {
        BST bst = new BST();
        new int[] {3, 2, 5, 1, 7, 9, 6}.ToList().ForEach(i => bst.Insert(i));
        if(bst.Root != null)
        {
            Write("BST in ascending order: ");
            PrintAscending(bst.Root);
            WriteLine(" ");
            Write("BST in descending order: ");
            PrintDescending(bst.Root);
            WriteLine(" ");
            WriteLine($"Count of primes in BST: {CountPrimeNodes(bst.Root)}");
            Write("Prime numbers in BST: ");
            DisplayPrime(bst.Root);
            WriteLine(" ");
            WriteLine($"BST Size: {GetBSTSize(bst.Root)}");
        }
    }
    static void PrintDescending(BSTNode? root)
    {
        if (root == null) return;
        if(root.Right != null) PrintDescending(root.Right);
        Write($"{root.Key, -2}");
        if(root.Left != null) PrintDescending(root.Left);
    }
    static void PrintAscending(BSTNode? root)
    {
        if (root == null) return;
        if(root.Left != null) PrintAscending(root.Left);
        Write($"{root.Key, -2}");
        if(root.Right != null) PrintAscending(root.Right);

    }
    static void DisplayPrime(BSTNode root)
    {
        if(root == null) return;
        if(IsPrime(root.Key).Equals(true)) Write($"{root.Key, -2}");
        if(root.Left != null) DisplayPrime(root.Left);
        if(root.Right != null) DisplayPrime(root.Right);
    } 
    static int CountPrimeNodes(BSTNode? root) //function travels each node in the tree and each node is considered the root note of the subtree. gets count from each node and combines the result.
    {
        if(root == null) return 0; //empty tree, no node no prime
        int count = IsPrime(root.Key)? 1 : 0; //Ternary Operateor - if root.Key is a prime or not then it will return true (1) or false (0) because isPrime is boolean. 
        if(root.Left != null) //if the left is not null then pass the whole left subtree back into the function and add it to the count.
        {
            count += CountPrimeNodes(root.Left);
        }
        if(root.Right != null) // if the right is not null then pass the whole right subtree back into the function and add it to the count.
        {
            count += CountPrimeNodes(root.Right);
        }
        return count;
    }    
    static int GetBSTSize(BSTNode? root)
    {
        if (root == null) return 0;
        int count = 1; //problem spot for me... assign the count variable 1 because its adding itself to itself... if that makes sense? its not just adding one everytime there is a node its adding itself. if i put two in there the output would be 14.
        if (root.Left != null)
        {
            count += GetBSTSize(root.Left);
        }
        if (root.Right != null)
        {
            count += GetBSTSize(root.Right);
        }
        return count;
    }
    static bool IsPrime(int n)
    {
        if(n <= 1) return false;
        if(n <= 3) return true;
        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }
}

class BST
{
    public BSTNode? Root {get; set;} //root node - always required - connects to every other node in the tree
    public bool Contains(int e)
    {
        BSTNode? t = Root;
        while(t != null)
        {
            if(e == t.Key) return true;
            else if(e < t.Key)
                t = t.Left; //keep seraching in left subtree
            else
                t = t.Right; //keep searching in the right subtree
        }
        return false; //because the previous loop didnt return true;
    }
    public bool Insert(int e){ //insert method takes an integer which is the key for the node to be inserted and then returns a boolean value. if the node is successfully inserted read true and if it isnt then read false. WHy would we not be able to insert the node? If it is a duplicate value it wont insert and will reject it.
        BSTNode node = new BSTNode(e); //pass the key e into the constructor in the BSTNode class (elem)
        if (Root == null){
            Root = node;
            return true;
        }
        BSTNode t = Root; // temporary pointer used to traverse through the tree.
        while(true){ //this loop will stop when an empty spot is found for the new node or if there is a duplicate found
            if(e < t.Key){ //go to left-subtree because new node is less than current node.
                if(t.Left == null){
                    t.Left = node;
                    return true;
                }
                //otherwise, if its not empty then keep going left.
                t = t.Left;
            }else if(e > t.Key){ //if key is greater than current key then go to the right sub-tree
                if(t.Right == null){ 
                    t.Right = node;
                    return true;
                }
                //otherwise if its not empty then keep going right.
                t = t.Right;
            }else{
                //t.Key must be equals to e, duplicate. return false
                return false;
            }
        }//end of while(true)
    }//end of Insert method
}
class BSTNode
{
    public int Key {get; set;} //use int for key but can be anything
    public BSTNode? Left {get; set;} //left subtree pointer
    public BSTNode? Right {get; set;} //right subtree pointer
    public BSTNode(int elem){ //constructor takes an element
        this.Key = elem;
    }
}

