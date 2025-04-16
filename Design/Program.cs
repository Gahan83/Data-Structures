using Design;

//ShuffleAnArray solution = new ShuffleAnArray(new int[] { 1, 2, 3 });

//var shuffled1 = solution.Shuffle();  // e.g., [3,1,2]
//var reset = solution.Reset();        // [1,2,3]
//var shuffled2 = solution.Shuffle();  // e.g., [1,3,2]

MinStack minStack = new MinStack();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
Console.WriteLine(minStack.GetMin()); // Output: -3
minStack.Pop();
Console.WriteLine(minStack.Top());    // Output: 0
Console.WriteLine(minStack.GetMin()); // Output: -2