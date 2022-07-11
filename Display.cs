using StacksandQueues.Common;

namespace StacksandQueues.Common
{
    public static class Display
    {
        public static void Problem1()
        {
            Console.Write("Please enter the string: ");
            string str = Console.ReadLine();

            IsValid(str);

            //Console.Write("Please enter the number of elements inside the linked list: ");
            //int length = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the elements: ");
            //LL lL = new LL();
            //int d;
            //for (int i = 1; i <= length; i++)
            //{
            //    Console.Write("Enter node " + i.ToString() + ": ");
            //    d = Convert.ToInt32(Console.ReadLine());
            //    lL.AddNode(new LL.Node(d));
            //}

            ////list before reversal
            //Console.Write("Given Linked List: ");
            //lL.PrintList();

            ////list after reversal
            //lL.ReverseList();
            //Console.Write("Reversed Linked List: ");
            //lL.PrintList();
        }

    }
}
