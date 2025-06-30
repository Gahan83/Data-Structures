namespace Arrays.Arrays
{
    public class Distinct
    {
        public bool ContainDuplicate(int[] nums)
        {
            //HashSet<int> set = new HashSet<int>();
            //foreach (int num in nums)
            //{
            //    if (set.Contains(num))
            //    {
            //        return true;
            //    }
            //    set.Add(num);
            //}
            //return false;

            //OR

            return nums.Distinct().Count() != nums.Length; // Returns true if there are any duplicate elements in the array; uses LINQ to compare the count of distinct element
        }
    }
}
