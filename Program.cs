/*
authour paul lopez
date 11/11/22
an implement of an integer linked list
*/

IntLinkedList il= new IntLinkedList();
IntStack ad = new IntStack();

il.Append(7);
il.Append(1337);
il.Append(10);
Console.WriteLine(il);
int? target = il.LookFor(7);
if (target != null)
{
    Console.WriteLine($"{target} has been found.");
}
else
{
    Console.WriteLine("Target not found...");
}
il.Prepend(8);
ad.Push(5);
Console.WriteLine(ad.Pop());

Console.WriteLine(ad.Peek());
Console.WriteLine(ad);

Console.WriteLine(il);
Console.WriteLine(il.Length());

// Console.WriteLine(target);
// Console.WriteLine(null);