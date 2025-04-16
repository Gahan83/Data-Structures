using Others;
//////////////////////////////: HammingDistance

//HammingDistance hammingDistance = new HammingDistance();

//int x = 1;  // You can change these values to test other inputs
//int y = 4;

//int distance = hammingDistance.HammingDistanceMethod(x, y);
//Console.WriteLine($"The Hamming distance between {x} and {y} is: {distance}");

//////////////////////////////: NumberOfOneBit

//NumberOfOneBit numberOfOneBit = new NumberOfOneBit();
//// Test cases
//int n=11; // Binary: 1011, Expected output: 3

//// Call the function to get the number of set bits
//int result = numberOfOneBit.HammingWeight(n);

//// Output the result
//Console.WriteLine($"The number of set bits in {n} is: {result}");

//////////////////////////////: ReverseBits
///
//ReverseBits reverseBits = new ReverseBits();
//uint input1 = 43261596; // 00000010100101000001111010011100
//uint output1 = reverseBits.ReverseBitsMethod(input1);
//Console.WriteLine($"Input: {input1}");
//Console.WriteLine($"Output: {output1}"); // Expected: 964176192

//////////////////////////////: PascalTriangle

//PascalTriangle pascalTriangle= new PascalTriangle();
//int numRows = 5; // You can change this to test other inputs
//var result = pascalTriangle.Generate(numRows);

//Console.WriteLine("Pascal's Triangle:");
//foreach (var row in result)
//{
//    Console.WriteLine(string.Join(" ", row));
//}

//////////////////////////////: ValidParentheses

//ValidParentheses validParentheses = new ValidParentheses();
//string input = "([])"; // You can change this to test other examples
//bool result = validParentheses.IsValid(input);
//Console.WriteLine($"Input: {input}");
//Console.WriteLine($"Is valid: {result}");

//////////////////////////////: MissingNumber
MissingNumber missingNumber = new MissingNumber();
int[] nums = { 3, 0, 1 }; // Change input here to test other examples
int missing = missingNumber.MissingNumberMethod(nums);
Console.WriteLine("Missing number is: " + missing);