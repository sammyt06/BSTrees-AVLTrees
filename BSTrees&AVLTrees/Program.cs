using System;

public class Program
{
    public static void Main()
    {
        BSTree<int> tree = new BSTree<int>();
        foreach (int value in new[] {30, 20 ,10 })
        {
            tree.InsertItem(value);
        }

        Console.WriteLine(tree.InOrder());

    }

}

