// /*
// authour paul lopez
// date 11/11/22
// an implement of an integer linked list
// */

// IntLinkedList il= new IntLinkedList();
// IntStack ad = new IntStack();

// il.Append(7);
// il.Append(1337);
// il.Append(10);
// Console.WriteLine(il);
// int? target = il.LookFor(7);
// if (target != null)
// {
//     Console.WriteLine($"{target} has been found.");
// }
// else
// {
//     Console.WriteLine("Target not found...");
// }
// il.Prepend(8);
// ad.Push(5);
// Console.WriteLine(ad.Pop());

// Console.WriteLine(ad.Peek());
// Console.WriteLine(ad);

// Console.WriteLine(il);
// Console.WriteLine(il.Length());

// // Console.WriteLine(target);
// // Console.WriteLine(null);


/*
authour paul lopez
date 11/11/24
an implement of an generic linked list
*/

LinkedList<int> il = new LinkedList<int>();
for (int i = 0; i < 10; i++)
{
    il.Prepend(i * 3 - 9);
}
Console.WriteLine(il);
Console.WriteLine(il.LookFor(0));
Console.WriteLine(il.RemoveFirst());
Console.WriteLine(il.LookAtFirst());

LinkedList<int> il2= new LinkedList<int>();
il2.Append(1);
il2.Append(2);
il2.Append(3);

LinkedList<LinkedList<int>> superlinkedlist = new LinkedList<LinkedList<int>>();
Console.WriteLine(superlinkedlist);