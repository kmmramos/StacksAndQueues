
using StacksandQueues.Logic;

namespace StacksandQueues.Common
{
    public static class Display
    {
        public static void Problem1()
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();

            ValidParenthesis stacksAndQueues = new ValidParenthesis();
            if (stacksAndQueues.IsValid(str))
            {
                Console.WriteLine("Valid Parenthesis");
            }
            else
            {
                Console.WriteLine("Invalid Parenthesis");
            }
        }

        public static void Problem2()
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();

            RemoveMinBrackets removeMinBrackets = new RemoveMinBrackets();
            Console.WriteLine(removeMinBrackets.Remove(str));
        }
    }
}