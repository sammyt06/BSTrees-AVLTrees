public class Node<T> where T : IComparable
{
    //Attributes
    private T data;
    public Node<T> Left, Right;

    //Constructor
    public Node(T item)
    {
        data = item;
        Left = null;
        Right = null;
    }

    //Subroutines
    public T Data
    {
        get { return data; }
        set { data = value; }
    }
}