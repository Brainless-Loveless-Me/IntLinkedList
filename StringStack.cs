class StringStack
{
    // Field
    private StringLinkedList il;

    public StringStack( )
    { 
        il = new StringLinkedList( );
    }

    public void Push(string value)
    {
        il.Prepend(value);
    }

    public string? Peek( )
    {
        return il.LookAtFirst( );
    }

    public string? Pop( )
    {
        return il.RemoveFirst( );
    }
    public bool isEmpty()
    {
        return il.IsEmpty();
    }
}
