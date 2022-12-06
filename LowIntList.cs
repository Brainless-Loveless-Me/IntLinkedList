/*
authour Paul
date 12/06/22
LowIntList
*/

class LowIntList<T>
{
    private LinkedList<int> list;
    public LowIntList()
    {
        list = new LinkedList<int>();
    }

    public int? LookAtFirst()
    {
        // return this.list.LookAtFirst();
        int? first = list.LookAtFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }

    public int? RemoveFirst()
    {
        // return this.list.RemoveFirst();
        int? first = list.RemoveFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }

    public void Append(int item)
    {
        if(item >= 100)
        {
            throw new NotSupportedException("Your a failure");
        }
        this.list.Append(item);
    }

    public void Prepend(int item)
    {
        if(item >= 100)
        {
            throw new NotSupportedException("Your a failure");
        }
        this.list.Prepend(item);
    }

    public bool IsEmpty()
    {
        return this.IsEmpty();
    }

    public bool LookFor(int item)
    {
        int? bob = list.LookFor(item);
        return bob != null;
    }

    public override string? ToString()
    {
        return this.list.ToString();
    }

    public int GetLength()
    {
        return this.list.Length();
    }
}