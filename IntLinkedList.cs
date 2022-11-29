/*
authour paul lopez
date 11/11/22
an implement of an integer linked list
*/

internal class IntLinkedList
{
    //todo: remove public modifier
    public class Node
    {
        //auto implemented properties
        public int Value{get; set;}
        public Node? Next {get; set;}

        public Node(int value)
        {
            this.Value =value;
            this.Next = null;
        }
    }

    //feild
    private int len;
    private Node? head;
    public Node? Head
    {
        get{return this.head; }
    }

    public IntLinkedList() {}
    public void Append(int value)
    {
        //construct a node based off of the value
        Node node = new Node(value);
        this.len += 1;
        //ez case: the head is null (the list is empty!)
        if(this.head == null)
        {
            this.head = node;
            return;
        }
        //find the end of the list
        Node curr = head;
        while (curr.Next != null)//while node has someone behind
        {
            //go to next node
            curr = curr.Next;
        }
        //the curr we are lookuing at does not have someone behind rthem
        //put node behind curr
        curr.Next = node;
    }
    
    public int? LookFor(int e)
    {
        // Lookup through list
        Node? curr = head;
        int? found = null;
        while (curr != null)
        {
            if(curr.Value == e)
            {
                found = curr.Value;
            }
            curr = curr.Next;
        }
        return found;
    }

    public override string ToString()
    {
        string listRepr = "";
        Node? curr = head;

        if (curr == null)
        {
            return "EMPTY";
        }
        while (curr.Next != null)
        {
            listRepr += curr.Value + " -> ";
            curr = curr.Next;
        }
        listRepr += curr.Value;
        // listRepr += "NULL";
        return listRepr;

    }

    public void Prepend(int e)
    {
        Node node = new Node(e);
        this.len += 1;
        if(this.head == null)
        {
            this.head = node;
        }
        Node Head = this.head;
        this.head = node;
        this.head.Next = Head;
    }

    public int Length()
    {
        return this.len;
    }

    public int? LookAtFirst( )
    {
        // If list is empty
        if (this.head == null)
        {
            return null;
        }
        return this.head.Value;
    }

    public int? RemoveFirst( )
    {
        if (this.head == null)
        {
            return null;
        }
        int headValue = this.head.Value;
        // Remove head
        this.head = this.head.Next;
        return headValue;
    }
    public bool IsEmpty()
    {
        // if(this.head == null)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        return this.head == null;
    }

}