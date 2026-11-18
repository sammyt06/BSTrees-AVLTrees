class BSTree<T> : BinTree<T> where T : IComparable
{   //Root declared as protected in Parent Class - Binary Tree
    
    public BSTree()
    {
        root = null;
    }

    private void InsertItem(T Item, ref Node<T> tree)
    {
        if(tree == null)
        {
            tree = new Node<T>(Item);
        }

        else if (Item.CompareTo(tree.Data) < 0)
        {
            InsertItem(Item, ref tree.Left); 
        }

        else if (Item.CompareTo(tree.Data) > 0)
        {
            InsertItem(Item, ref tree.Right);
        }

    }

    public void InsertItem(T Item)
    {
        InsertItem(Item, ref root);
    }

    protected int Height(Node<T> tree)
    {
        if (tree == null)
        {
            return -1;
        }

        int leftHeight = Height(tree.Left);
        int rightHeight = Height(tree.Right);

        return 1 + Math.Max(leftHeight, rightHeight);

    }

}