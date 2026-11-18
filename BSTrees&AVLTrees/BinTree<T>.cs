class BinTree<T> where T : IComparable
{
    //Attributes
    protected Node<T> root;

    //Constructor
    public BinTree()
    {
        root = null;
    }

    public BinTree(Node<T> node)
    {
        root = node;
    }

    private void InOrder(Node<T> tree, ref string buffer)
    {
        if (tree != null)
        {
            InOrder(tree.Left, ref buffer);
            buffer += tree.Data + " ";
            InOrder(tree.Right, ref buffer);
        }
    }

    public string InOrder()
    {
        string buffer = "";
        InOrder(root, ref buffer);
        return buffer;
    }

    private int GetHeight(Node<T> root)
    {
        if (root == null)
        {
            return -1;
        }
        
        int leftHeight = GetHeight(root.Left);
        int rightHeight = GetHeight(root.Right);

        return Math.Max(leftHeight, rightHeight) + 1;

    }

    public int GetHeight()
    {
        return GetHeight(root);
    }


    private int Count(Node<T> root)
    {

        if (root == null)
        {
            return 0;
        }

        return 1 + Count(root.Left) + Count(root.Right);
    }
    public int Count(){
        return Count(root);
    }

    private Boolean Contains(T item, Node<T> tree)
    {
        if (tree == null)
        {
            return false;
        }

        int compared = item.CompareTo(tree.Data);

        if (compared == 0)
        {
            return true;
        }
        else if (compared < 0)
        {
            return Contains(item, tree.Left);
        }
        
        return Contains(item, tree.Right);
    }

    public Boolean Contains(T item)
    {
        return Contains(item,root);
    }



}