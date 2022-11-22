class IntStack
{
    // Field
    private IntLinkedList il;

    public IntStack( )
    { 
        il = new IntLinkedList( );
    }

    public void Push(int value)
    {
        il.Prepend(value);
    }

    public int? Peek( )
    {
        return il.LookAtFirst( );
    }

    public int? Pop( )
    {
        return il.RemoveFirst( );
    }
    public string isEmpty()
    {
        if (il.IsEmpty() == true)
        {
            return "Empty";
        }
        else
        {
            return "Is not empty";
        }
    }
}
