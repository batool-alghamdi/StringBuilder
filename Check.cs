using System;
using System.Collections.Generic;
namespace practice
{
    public class Check
    {
		public static bool CheckOrder(string source)
		{
			Stack<char> stack = new Stack<char>();
			stack.Push(source[0]);
			int i = 0;
			while(i< source.Length)
            {
				if (stack.Peek() == source[i])
					stack.Pop();
				else
					stack.Push(source[i]);
				i++;
			}
			return stack.Count == 0 ? true : false;
		}
		public static void Main()
		{
			string[] arrayOfStrings = { "12344321", "1234445353321", "1235353321", "1235335321", "893398" };
			foreach (string str in arrayOfStrings)
			{
				Console.WriteLine("CheckOrder(" + str + "): " + CheckOrder(str));
			}
		}
	}
}
