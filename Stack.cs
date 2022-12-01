/*
authour paul
date 11/29/22
a generic stack implementation
*/

class Stack<T>
{   
    //feilds
    private LinkedList<T> list;

    //constructor
    public Stack()
    {
        list = new LinkedList<T>();
    }
    public void Push(T item)
    {
        list.Prepend(item);
    }

    public T Peek()
    {
        T? first = list.LookAtFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }
    public T Pop()
    {
        T? first = list.RemoveFirst();
        if (first == null)
        {
            throw new InvalidOperationException("Cannot look at first element of an empty stack.");
        }
        return first;
    }

    public bool isEmpty()
    {
        return list.IsEmpty();
    }
}