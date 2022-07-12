using System.Collections;

namespace StacksandQueues.Logic
{
    public class ImplementQueueWithStack
    {
        public Stack s1 = new Stack();
        public Stack s2 = new Stack();

        public void Enqueue(int s)
        {
            // move all elements from s1 to s2
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            // push item into s1
            s1.Push(s);

            // push everything back to s1
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        // dequeue on item from queue
        public int Dequeue()
        {
            // if first stack is empty
            if (s1.Count == 0)
            {
                Console.WriteLine("Q is empty");
            }

            // return top of s1
            int x = (int) s1.Peek();
            s1.Pop();
            return x;
        }

        public void Main()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.Write(q.Dequeue() + " ");
            Console.Write(q.Dequeue() + " ");
            Console.Write(q.Dequeue());
        }
    }
}
