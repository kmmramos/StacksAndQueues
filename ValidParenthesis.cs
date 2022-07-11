using System;

namespace StacksandQueues.Common
{
	public class ValidParenthesis
	{
		public bool IsValid(string s)
		{
			Stack left = new Stack();
			foreach (char c in s.ToCharArray())
			{
				if (c == '(' || c == '[' || c == '{')
				{
					left.Push(c);
				}
				else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
				{
					left.Pop();
				}
				else if (c == ']' && left.Count != 0 && (char)left.Peek() == ']')
				{
					left.Pop();
				}
				else if (c == '}' && left.Count != 0 && (char)left.Peek() == '}')
				{
					left.Pop();
				}
				else
				{
					return false;
				}
				if (left.Count != 0)
				{
					return true;
				}
			}
		}
	}
}