using System;
using System.Collections;
using System.Collections.Generic;
/*
 * Assignment 1: Create generic class name mystack, which only contains two 
 * methods push and pop. It must provide or simulate functionality (push and pop) 
 * of .net in built generic class stack.
 */
namespace StackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("Amey");
            stack.Push("Katik");
            stack.Push("Gourav");
            stack.Push("Mohanish");
            stack.Push("Khushal");
            Console.WriteLine("*** Element pushed ***");

            foreach (String i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Popped element: ");

            stack.Pop();
            Console.WriteLine("*** Elements after Pop ***");

            foreach (String i in stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    public class MyStack<UnknownDataType> : IEnumerable
    {
        Stack<UnknownDataType> stack = new Stack<UnknownDataType>();
        public void Push(UnknownDataType Element)
        {
            stack.Push(Element);
        }
        public void Pop()
        {
            Console.WriteLine(stack.Pop());
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)stack).GetEnumerator();
        }
    }
}
