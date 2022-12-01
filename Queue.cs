class Queue<T>
{
    private LinkedList<T> queue;

    public Queue()
    {
        queue = new LinkedList<T>();
    }

    public T Peek()
    {
        T? first = queue.LookAtFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }

    public void Enqueue(T item)
    {
        queue.Append(item);
    }

    public T Dequeue()
    {
        T? first = queue.RemoveFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }

    public T Contains(T item)
    {
        T? bob = queue.LookFor(item);
        if (bob == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return bob;
    }

    public override string ToString()
    {
        return queue.ToString();
    }
}