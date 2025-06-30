using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class MinStack // Defining the MinStack class
    {
        private Stack<int> stack; // Stack to store all values
        private Stack<int> minStack; // Stack to keep track of minimum values

        public MinStack() // Constructor to initialize stacks
        {
            stack = new Stack<int>(); // Initialize the main stack
            minStack = new Stack<int>(); // Initialize the min stack
        }

        public void Push(int val) // Method to push a value onto the stack
        {
            stack.Push(val); // Push value onto the main stack
            if (minStack.Count == 0 || val <= minStack.Peek()) // If minStack is empty or new value is less than or equal to current min
            {
                minStack.Push(val); // Push value onto the min stack
            }
        }

        public void Pop() // Method to remove the top value from the stack
        {
            int top = stack.Pop(); // Pop the top value from the main stack
            if (top == minStack.Peek()) // If the popped value is the current minimum
            {
                minStack.Pop(); // Pop it from the min stack as well
            }
        }

        public int Top() // Method to get the top value of the stack
        {
            return stack.Peek(); // Return the top value of the main stack
        }

        public int GetMin() // Method to get the minimum value in the stack
        {
            return minStack.Peek(); // Return the top value of the min stack (current minimum)
        }
    }
}
