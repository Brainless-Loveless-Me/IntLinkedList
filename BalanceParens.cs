class BalanceParens
{
    public static char[][] Tokens = new char[][] { new char[] { '{', '}' }, new char[] { '[', ']' }, new char[] { '(', ')' } };
    public static bool isOpenTerm(char c)
    {
        foreach(char[] array in Tokens)
        {
            if (array[0] == c)
            {
                return true;
            }
        }
        return false;
    }
    public static bool matches(char openTerm, char closeTerm)
    {
        foreach(char[] array in Tokens)
        {
            if (array[0] == openTerm)
            {
                return array[1] == closeTerm;
            }
        }
        return false;
    }
    public static bool isBalanced(string expression)
    {
        IntStack stack = new IntStack();
        foreach(char c in expression.ToCharArray())
        {
            if (isOpenTerm(c))
            {
                stack.Push(c);
            }
            else
            {
                if(stack.isEmpty() || !matches((char)(stack.Pop()), c))
                {
                    return false;
                }
            }
        }
        return stack.isEmpty();
    }
}