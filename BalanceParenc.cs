/*
authour paul lopez
date 11/30/22
hacker rank balance parens solution
*/


class Bracket
{
    //auto implemented property
    public char open{get;}
    public char close {get;}

    public Bracket(char open, char close)
    {
        this.open = open;
        this.close = close;
    }

    public bool Matches(char open)
    {
        if(close == this.close)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class BalanceParenc
{
    public static Bracket CreateBracketFromOpen(Bracket[] brackets, char openBracket)
    {
        Bracket? b = null;
        foreach(Bracket bracket in brackets)
        {
            if(bracket.open == openBracket)
            {
                b= bracket;
            }
        }
        if(b == null)
        {
            throw new Exception($"{openBracket} is not a valid open bracket");
        }
        return b;
    }
    public static void Main()
    {
        String parensSentence = "({}[([])]}";
        Bracket[] brackets = new Bracket[3]
        {
            new Bracket('[', ']'),
            new Bracket('{', '}'),
            new Bracket('(', ')')
        };

        Stack<Bracket> stack = new Stack<Bracket>();
         // loop through brackets in our sentence
        foreach (char b in parensSentence)
        {
            bool isOpen =false;
            foreach(Bracket bracket in brackets)
            {
                if(b == bracket.open)
                {
                    isOpen = true;
                }
            }
            //if character we look at is open bracket
            //simply push it into stack
            if(isOpen)
            {
                Bracket ob =CreateBracketFromOpen(brackets, b); 
                stack.Push(ob);
            }
            else
            {
                //pop from stack to greet thr next ipen bracket
                Bracket openBracketClass = stack.Pop();
                if(!openBracketClass.Matches(b))
                {
                    break;
                }
                // char openBracket= stack.Pop();
                // //check if this openBracket matches the current b (blosing bracket)
                // //get the bracket class that corresponds to this openBracket
                // Bracket? bracketPair = null;
                // foreach(Bracket bracket in brackets)
                // {
                //     if(openBracket == bracket.open)
                //     {
                //         bracketPair = bracket;
                //     }
                // }
                // if (bracketPair == null)
                // {
                //     Console.WriteLine("there was a problem");
                //     break;
                // }

                // if (!bracketPair.Matches(b))
                // {
                //     Console.WriteLine("not balanced ...");
                //     break;
                // }
            }
        }
        //if there is anything in the stack, then it is not balanced
        //otherwise, it is balanced
        if(stack.isEmpty())
        {
            Console.WriteLine("Balanced");
        }
        else
        {
            Console.WriteLine("Not Balanced");
        }
    }
}
