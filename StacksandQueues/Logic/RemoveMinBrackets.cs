using System.Collections;

namespace StacksandQueues.Logic
{
    public class RemoveMinBrackets
    {
        public string Remove(string s)
        {
            char[] res = s.ToCharArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == '(')
                {
                    stack.Push(i);
                }
                else if (res[i] == ')' && stack.Count != 0)
                {
                    stack.Pop();
                }
                else if (res[i] == ')')
                {
                    res[i] = '\0';
                }
            }
            while (stack.Count != 0)
            {
                int currentIndex = stack.Pop();
                res[currentIndex] = '\0';
            }
            String yup = new String(res);
            return yup;
        }
    }
}
