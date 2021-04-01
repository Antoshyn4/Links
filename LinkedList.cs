using System;

public class LinkedList
{
    public Node<T> first { get; private set; }
    public Node<T> last { get; private set; }

    public int Length { get; private set; }

    public LinkedList()
    {
        first = null;
        last = null;
        Length = 0;
    }

    public LinkedList(T data)
    {
        var node = new Node<T>(data);
        first = node;
        last = node;
        Length = 1;
    }

    public bool IsEmpty(){return !(bool)Length}

    public void Print()
    {
        if (!IsEmpty())
        {
            foreach (var item in LinkedList)
            {
                Console.WriteLine(item.Node);
            }
        }
        else
            Console.WriteLine("Error, List is empty");
    }

    public void Add(T data)
    {
        var node = new Node<T>(data);
        if (IsEmpty())
        {
            first = node;
            last = node;
            Length = 1;
        }
        else
        {
            last.Next = node;
            last = node;
            Length++;
        }
    }
}
