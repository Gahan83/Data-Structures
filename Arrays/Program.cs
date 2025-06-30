using Arrays.Arrays;

//Merged Sorted Array
//int[] nums1 = { 1, 2, 3, 0, 0, 0 };
//int m = 3;
//int[] nums2 = { 2, 5, 6 };
//int n = 3;
//new MergeSortedArray().Merge(nums1, m, nums2, n);
//Console.WriteLine(string.Join(", ", nums1));

//int[] nums1 = { 1 };
//int m = 1;
//int[] nums2 = { };
//int n = 0;
//new MergeSortedArray().Merge(nums1, m, nums2, n);
//Console.WriteLine(string.Join(", ", nums1));

//int[] nums1 = { 0 };
//int m = 0;
//int[] nums2 = { 1 };
//int n = 1;
//new MergeSortedArray().Merge(nums1, m, nums2, n);
//Console.WriteLine(string.Join(", ", nums1));



//-------------------------------------------------------------------

//RemoveDuplicatesFromSortedArrays result = new RemoveDuplicatesFromSortedArrays();
//int[] nums1 = { 1, 1, 2, 2, 3, 4 };
//int truncatedResult = result.RemoveDuplicates(nums1);
//Console.WriteLine(string.Join(",", nums1.Take(truncatedResult)));

//BuyAndSellStock result = new BuyAndSellStock();
//int[] prices = { 1, 2, 3, 4, 5 };
//Console.WriteLine(result.MaxProfit(prices));

//RotateArray rotateArray = new RotateArray();
//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 4;

//rotateArray.Rotate(nums, k);
//Console.WriteLine(string.Join(",", nums));

//Distinct distinct = new Distinct();
//int[] nums = { 1, 5, 3, 4, 5, 5, 7 };
//Console.WriteLine(distinct.ContainDuplicate(nums));

//SingleNumber singleNumber = new SingleNumber();
//int[] nums = { 1, 2, 2, 1, 6 };
//Console.WriteLine(singleNumber.FindSingleNumber(nums));

//IntersectionofArray intersectionofArray = new IntersectionofArray();

//int[] nums1 = { 1, 2, 3 };
//int[] nums2 = { 2, 3, 4 };
//int[] result = intersectionofArray.Intersect(nums1, nums2);

//Console.WriteLine(string.Join(",",result));

//PlusOne plusOne = new PlusOne();
//int[] digits = { 4, 3, 2,1 };
//Console.WriteLine(string.Join(",", plusOne.AddOne(digits)));

//NonZeros nonZeros = new NonZeros();
//int[] nums = { 0, 1, 0, 3, 12 };
//nonZeros.MoveZeros(nums);
//Console.WriteLine(string.Join(",", nums));

//SmallestNumber number = new SmallestNumber();
//int[] nums = { 0, 1, 0, 3, 12 };
//number.PickSmallNumber(nums);

//MinimumEvenNumber number = new MinimumEvenNumber();
//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//number.MinEvenNumber(nums);

SumofArray number = new SumofArray();
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 9 };
number.Sum(nums);

//CountofArray number = new CountofArray();
//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//number.Count(nums);

//AverageofArray number = new AverageofArray();
//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//number.Average(nums);

//string[] names = { "Bangalore", "Mangalore", "Mumbai", };
//CombineToSingleString combineToSingleString = new CombineToSingleString();
//combineToSingleString.Combine(names);

//int[] nums = { 11, 15, 2, 7};
//int target = 9;
//TwoSum twoSum = new TwoSum();
//int[] result = twoSum.Sum(nums, target);
//Console.WriteLine(string.Join(",",result));

Sudoku sudoku = new Sudoku();
char[][] board = {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

Console.WriteLine(sudoku.IsValidSudoku(board));


//int[][] matrix = {
//            new int[] {1, 2, 3},
//            new int[] {4, 5, 6},
//            new int[] {7, 8, 9}
//        };

//RotateImage rotateImage = new RotateImage();
//rotateImage.Rotate(matrix);

//foreach (var i in matrix)
//{
//    Console.WriteLine(string.Join("", i));
//}


//MaximumEvenNumber maximumEvenNumber = new MaximumEvenNumber();

//maximumEvenNumber.MaxEvenNumber(new int[] { 1, 2, 3, 4, 5, 6, 7 });




