
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {



           Stack<int> stack = new Stack<int>();
            stack.Push(1); // inserting value
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
          

            Console.WriteLine("The stack are "+ stack.Count);
           
            foreach (var i in stack)
                Console.WriteLine(i+",Hello:");

            /*  while (stack.Count > 0) 
                  Console.WriteLine(stack.Pop());  // removing value
              Console.WriteLine();

              Console.WriteLine("no of elements in stack:{0}",stack.Count);*/

            if(stack.Count > 0)

            {
                Console.WriteLine(stack.Peek()); // pick the value one by one
            }

            Console.WriteLine("Number of elements in Stack: {0}", stack.Count);

        }
    }
}
