/*
authour paul
date 11/22/22
RPN solver
*/

class RPNSolver
{
    public static void Main()
    {
        string equation = "6 3 4 + 5 * + 7 -";
        string [] parts = equation.Split(' ');
        
        IntStack stack = new IntStack();

        foreach (string ep in parts)
        {
            int tempNum = 0;
            bool isDigit = Int32.TryParse(ep, out tempNum);
            if (isDigit)
            {
                stack.Push(tempNum);
            }
            else
            {
                int? num1 = stack.Pop();
                int? num2 = stack.Pop();
                if (ep == "+")
                {
                    int? sum = num1 + num2;
                    // if (sum == null) sum = 0;
                    stack.Push((int)sum);
                }
                else if (ep == "-")
                {
                    int? diff = num1 - num2;
                    // if (sum == null) sum = 0;
                    stack.Push((int)diff);
                }
                else if (ep == "*")
                {
                    int? prod = num1 * num2;
                    // if (sum == null) sum = 0;
                    stack.Push((int)prod);
                }
                else if (ep == "/")
                {
                    int? quot = num1 / num2;
                    // if (sum == null) sum = 0;
                    stack.Push((int)quot);
                }
            }
        }
        Console.WriteLine(stack.Pop());
    }
}